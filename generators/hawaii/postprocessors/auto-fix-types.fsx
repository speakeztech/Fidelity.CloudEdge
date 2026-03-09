#!/usr/bin/env dotnet fsi

// Universal Hawaii compatibility post-processor.
// Fixes common code generation issues using Active Patterns for parsing:
//
//   1. Invalid type/case names ($, +) renamed to valid F# identifiers
//   2. Bare $/@-prefixed identifiers get backtick quoting
//   3. Undefined type references get aliases or stubs
//
// Usage:
//   dotnet fsi auto-fix-types.fsx <Types.fs> [<Client.fs>]

open System
open System.IO
open System.Text.RegularExpressions

// ── Active Patterns for line classification ─────────────────────

/// Classify a line as code or non-code (comment, attribute, string)
let (|CommentLine|AttributeLine|CodeLine|) (line: string) =
    let trimmed = line.TrimStart()
    if trimmed.StartsWith("///") || trimmed.StartsWith("//") then CommentLine
    elif trimmed.StartsWith("[<") then AttributeLine
    else CodeLine

/// Match a backtick-quoted identifier at a position
let (|BacktickAt|_|) (s: string) (pos: int) =
    if pos + 3 < s.Length && s.[pos] = '`' && s.[pos+1] = '`' then
        let endIdx = s.IndexOf("``", pos + 2)
        if endIdx > pos + 2 then Some (s.Substring(pos + 2, endIdx - pos - 2), endIdx + 2)
        else None
    else None

/// Match a bare identifier at a position
let (|IdentAt|_|) (s: string) (pos: int) =
    if pos < s.Length && (Char.IsLetter s.[pos] || s.[pos] = '_') then
        let mutable i = pos + 1
        while i < s.Length && (Char.IsLetterOrDigit s.[i] || s.[i] = '_') do i <- i + 1
        Some (s.Substring(pos, i - pos), i)
    else None

/// Match either backtick-quoted or bare identifier
let (|TypeAt|_|) (s: string) (pos: int) =
    match (|BacktickAt|_|) s pos with
    | Some _ as r -> r
    | None -> (|IdentAt|_|) s pos

/// Skip whitespace
let skipWS (s: string) (pos: int) =
    let mutable i = pos
    while i < s.Length && Char.IsWhiteSpace s.[i] do i <- i + 1
    i

// ── Type definition extraction ──────────────────────────────────

/// Extract all type names defined in the file
let collectDefinitions (content: string) =
    content.Split('\n')
    |> Array.choose (fun line ->
        let t = line.TrimStart()
        if t.StartsWith("type ") then
            let p = skipWS t 5
            match (|TypeAt|_|) t p with
            | Some (name, np) ->
                let afterName = skipWS t np
                if afterName < t.Length && (t.[afterName] = '=' || t.[afterName] = '(') then Some name
                else None
            | None -> None
        else None)
    |> Set.ofArray

// ── Type reference extraction (code lines only) ─────────────────
// Processes each line, skipping comments and attributes, extracting
// type names from: field annotations, DU payloads, generic args, type aliases

let extractTypeRef (line: string) (pos: int) =
    let p = skipWS line pos
    // Unwrap Option<X> or list<X>
    match (|IdentAt|_|) line p with
    | Some (wrapper, np) when (wrapper = "Option" || wrapper = "list") && np < line.Length && line.[np] = '<' ->
        match (|TypeAt|_|) line (np + 1) with
        | Some (inner, _) -> [inner]
        | None -> []
    | _ ->
        match (|TypeAt|_|) line p with
        | Some (name, _) -> [name]
        | None -> []

let collectTypeRefsFromLine (line: string) =
    match line with
    | CommentLine | AttributeLine -> []
    | CodeLine ->
        let refs = ResizeArray<string>()
        let mutable i = 0
        while i < line.Length - 1 do
            match line.[i] with
            | ':' when i > 0 ->
                // Type annotation: "name: Type" — but NOT in string literals or URLs
                let before = line.[i-1]
                if Char.IsLetterOrDigit before || before = ')' || before = '?' || before = ' ' || before = '`' then
                    for r in extractTypeRef line (i + 1) do refs.Add r
                i <- i + 1
            | '<' ->
                // Generic type arg: <Type>
                for r in extractTypeRef line (i + 1) do refs.Add r
                i <- i + 1
            | 'o' when i + 2 < line.Length && line.[i+1] = 'f' && (i = 0 || not (Char.IsLetterOrDigit line.[i-1])) ->
                let afterOf = if i + 2 < line.Length && line.[i+2] = ' ' then i + 2 else -1
                if afterOf > 0 then
                    // Check for "of payload: Type" pattern
                    let p = skipWS line afterOf
                    match (|IdentAt|_|) line p with
                    | Some ("payload", np) when np < line.Length && line.[np] = ':' ->
                        for r in extractTypeRef line (np + 1) do refs.Add r
                    | _ -> ()
                    for r in extractTypeRef line afterOf do refs.Add r
                i <- i + 1
            | _ -> i <- i + 1
        refs |> Seq.toList

let collectTypeReferences (content: string) =
    content.Split('\n')
    |> Array.collect (fun line -> collectTypeRefsFromLine line |> Array.ofList)
    |> Set.ofArray

// ── Exclusion list ──────────────────────────────────────────────

let excludedNames = set [
    // F# primitive types
    "string"; "int"; "float"; "bool"; "obj"; "unit"; "byte"; "double"
    "int64"; "float32"; "decimal"; "char"; "Option"; "list"; "Map"
    "async"; "Async"; "seq"; "array"; "int32"; "true"; "false"
    // .NET / library types
    "CancellationToken"; "HttpClient"; "JsonConverter"
    // F# keywords (would cause FS0010 if used as type names)
    "when"; "type"; "let"; "in"; "do"; "done"; "for"; "while"; "if"
    "then"; "else"; "elif"; "match"; "with"; "function"; "fun"; "try"
    "finally"; "yield"; "return"; "use"; "module"; "namespace"; "open"
    "member"; "static"; "abstract"; "override"; "default"; "mutable"
    "rec"; "and"; "or"; "not"; "new"; "null"; "void"; "class"; "struct"
    "interface"; "inherit"; "begin"; "end"; "lazy"; "as"; "assert"; "base"
    "downcast"; "downto"; "extern"; "fixed"; "global"; "inline"; "internal"
    "of"; "private"; "public"; "sig"; "to"; "upcast"; "val"; "virtual"
    "volatile"; "val"; "raise"; "exception"; "delegate"; "enum"; "measure"
    // Common English words that appear in code/comments but aren't types
    "payload"; "key"; "value"; "name"; "body"; "result"
    "the"; "this"; "that"; "which"; "from"; "into"; "each"; "some"
    "where"; "what"; "how"; "all"; "any"; "can"; "has"; "have"; "had"
    "are"; "was"; "were"; "been"; "being"; "will"; "would"; "should"
    "could"; "may"; "might"; "must"; "shall"; "need"; "used"; "set"
    "get"; "put"; "post"; "delete"; "patch"; "head"; "options"
    "data"; "item"; "items"; "count"; "total"; "page"; "size"; "index"
    "content"; "status"; "code"; "message"; "error"; "errors"; "response"
    "request"; "method"; "path"; "query"; "header"; "headers"; "format"
    "length"; "start"; "stop"; "timeout"; "limit"; "offset"; "cursor"
    "per"; "via"
]

let isExcluded (name: string) =
    excludedNames.Contains name ||
    name.Length <= 2 ||
    name.StartsWith "System" ||
    name.StartsWith "Newtonsoft" ||
    name.StartsWith "Microsoft" ||
    name.StartsWith "Fable" ||
    name.StartsWith "OpenApiHttp" ||
    name.StartsWith "CompiledName" ||
    name.StartsWith "RequireQualifiedAccess" ||
    name.StartsWith "StringEnum" ||
    // Uppercase first letter = likely a .NET type or DU case, not a Hawaii schema type
    // Hawaii schema types always start lowercase (or with backtick-quoted names containing hyphens)
    (name.Length > 0 && Char.IsUpper name.[0] && not (name.Contains "-"))

// ── Type name normalization and matching ─────────────────────────

let normalize (name: string) = name.Replace("_", "")

let findMatch (definitions: Set<string>) (undefinedRef: string) =
    let normalized = normalize undefinedRef
    definitions |> Set.toSeq |> Seq.tryFind (fun d -> normalize d = normalized)

// ── Formatting helpers ──────────────────────────────────────────

let needsBackticks (name: string) =
    name.Contains "-" || name.Contains "$" || name.Contains " " ||
    name.Contains "+" || name.Contains "@"

let formatTypeName (name: string) =
    if needsBackticks name then sprintf "``%s``" name else name

// ── Fix 1: Rename types with invalid chars ($, +) ──────────────

let hasInvalidTypeChars (name: string) =
    name.Contains "$" || name.Contains "+"

let sanitizeTypeName (name: string) =
    name.Replace("$", "Dollar_").Replace("+", "Plus_")

let renameInContent (content: string) (oldName: string) (newName: string) =
    content.Replace(sprintf "``%s``" oldName, formatTypeName newName)

// ── Fix 2: Backtick-quote bare $/@-prefixed identifiers ─────────

let fixBareSpecialIdentifiers (content: string) =
    let mutable result = content
    let mutable count = 0

    result <- Regex.Replace(result, @"\((\$[a-zA-Z_][a-zA-Z0-9_]*)\)", fun m ->
        count <- count + 1
        sprintf "(``%s``)" m.Groups.[1].Value)

    result <- Regex.Replace(result, @"(=\s+)(\$[a-zA-Z_][a-zA-Z0-9_]*)(\s|$|;)", fun m ->
        count <- count + 1
        sprintf "%s``%s``%s" m.Groups.[1].Value m.Groups.[2].Value m.Groups.[3].Value)

    result <- Regex.Replace(result, @"\|\s+\((@[a-zA-Z_][a-zA-Z0-9_]*)\)\s+->", fun m ->
        count <- count + 1
        sprintf "| ``%s`` ->" m.Groups.[1].Value)

    count, result

// ── Main ────────────────────────────────────────────────────────

let args = fsi.CommandLineArgs |> Array.tail

if args.Length = 0 then
    eprintfn "Usage: dotnet fsi auto-fix-types.fsx <Types.fs> [<Client.fs>]"
    exit 1

let typesFile = args.[0]
let clientFile = if args.Length > 1 then Some args.[1] else None

printfn "Auto-fix types: %s" typesFile

if not (File.Exists typesFile) then
    eprintfn "Error: File not found: %s" typesFile
    exit 1

let mutable typesContent = File.ReadAllText typesFile
let mutable clientContent =
    match clientFile with
    | Some f when File.Exists f -> Some (File.ReadAllText f)
    | _ -> None

let mutable totalChanges = 0

// ── Step 1: Rename all identifiers with invalid characters ──────
// Scan for ALL backtick-quoted identifiers containing $ or + (type defs AND DU cases)

let collectBacktickNames (content: string) =
    Regex.Matches(content, @"``([^`]+)``")
    |> Seq.cast<Match>
    |> Seq.map (fun m -> m.Groups.[1].Value)
    |> Seq.distinct
    |> Seq.filter hasInvalidTypeChars
    |> Seq.toList

for oldName in collectBacktickNames typesContent do
    let newName = sanitizeTypeName oldName
    printfn "  Renaming: %s -> %s" oldName newName
    typesContent <- renameInContent typesContent oldName newName
    clientContent <- clientContent |> Option.map (fun c -> renameInContent c oldName newName)
    totalChanges <- totalChanges + 1

// ── Step 2: Fix bare special-char identifiers ───────────────────

let specialCount, fixedTypes = fixBareSpecialIdentifiers typesContent
typesContent <- fixedTypes
if specialCount > 0 then
    printfn "  Fixed %d bare special-char identifier(s)" specialCount
    totalChanges <- totalChanges + specialCount

// ── Step 3: Detect undefined types and add aliases/stubs ────────

let updatedDefs = collectDefinitions typesContent

let typesRefs = collectTypeReferences typesContent
let clientRefs = match clientContent with Some c -> collectTypeReferences c | None -> Set.empty
let allRefs = Set.union typesRefs clientRefs

let undefinedRefs = allRefs |> Set.filter (fun r -> not (Set.contains r updatedDefs) && not (isExcluded r))

let mutable aliasLines = []
let mutable stubLines = []

for undef in undefinedRefs do
    match findMatch updatedDefs undef with
    | Some d when d <> undef ->
        aliasLines <- sprintf "type %s = %s" (formatTypeName undef) (formatTypeName d) :: aliasLines
        printfn "  Alias: %s -> %s" undef d
        totalChanges <- totalChanges + 1
    | _ ->
        stubLines <- sprintf "type %s = string" (formatTypeName undef) :: stubLines
        printfn "  Stub:  %s = string" undef
        totalChanges <- totalChanges + 1

if aliasLines.Length > 0 || stubLines.Length > 0 then
    let nsMatch = Regex.Match(typesContent, @"(namespace\s+rec\s+[^\r\n]+)")
    if nsMatch.Success then
        let lines =
            [ if aliasLines.Length > 0 then
                yield "\n// Auto-generated type aliases (Hawaii normalization fix)"
                yield! aliasLines |> List.rev
              if stubLines.Length > 0 then
                yield "\n// Auto-generated stub types (missing from Hawaii output)"
                yield! stubLines |> List.rev ]
        typesContent <- typesContent.Insert(nsMatch.Index + nsMatch.Length, "\n" + String.concat "\n" lines)

// ── Write results ───────────────────────────────────────────────

if totalChanges > 0 then
    File.WriteAllText(typesFile, typesContent)
    match clientFile, clientContent with
    | Some f, Some c -> File.WriteAllText(f, c)
    | _ -> ()
    printfn "Applied %d fix(es)" totalChanges
else
    printfn "  No fixes needed"
