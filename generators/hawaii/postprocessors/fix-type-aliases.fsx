#!/usr/bin/env dotnet fsi

// Post-processor for Hawaii type name normalization mismatches.
// Hawaii sometimes generates inconsistent type names — the type definition
// uses one normalization (e.g. workers-kvkeynamebulk) but references use
// the original OpenAPI schema name (e.g. workers-kv_key_name_bulk).
// This script adds type aliases so both names resolve correctly.
//
// Usage:
//   dotnet fsi fix-type-aliases.fsx <Types.fs> --aliases "ref=def,ref2=def2"
//
// Example:
//   dotnet fsi fix-type-aliases.fsx Generated-KV/Types.fs \
//     --aliases "workers-kv_key_name_bulk=workers-kvkeynamebulk,workers-kvvalue=string"
//
// Each alias mapping is: undefinedReference=existingDefinition
// For simple type aliases (like string), no backtick quoting is needed.
// For Hawaii-generated names with hyphens, backticks are added automatically.

open System
open System.IO
open System.Text.RegularExpressions

// ── Argument Parsing ─────────────────────────────────────────────

type Alias = { Reference: string; Definition: string }

type Config =
    { TypesFile: string
      Aliases: Alias list }

let needsBackticks (name: string) =
    // Names with hyphens or starting with $ need backtick quoting in F#
    name.Contains("-") || name.Contains("$") || name.Contains(" ")

let formatTypeName (name: string) =
    if needsBackticks name then sprintf "``%s``" name
    else name

let parseArgs (args: string[]) =
    let mutable typesFile = ""
    let mutable aliasStr = ""
    let mutable i = 0

    while i < args.Length do
        match args.[i] with
        | "--aliases" when i + 1 < args.Length ->
            aliasStr <- args.[i + 1]
            i <- i + 2
        | s when not (s.StartsWith("--")) && typesFile = "" ->
            typesFile <- s
            i <- i + 1
        | other ->
            eprintfn "Unknown argument: %s" other
            exit 1

    if typesFile = "" || aliasStr = "" then
        eprintfn "Usage: dotnet fsi fix-type-aliases.fsx <Types.fs> --aliases \"ref=def,ref2=def2\""
        exit 1

    let aliases =
        aliasStr.Split(',')
        |> Array.map (fun pair ->
            match pair.Split('=') with
            | [| ref_; def_ |] -> { Reference = ref_.Trim(); Definition = def_.Trim() }
            | _ ->
                eprintfn "Invalid alias format: %s (expected ref=def)" pair
                exit 1)
        |> Array.toList

    { TypesFile = typesFile; Aliases = aliases }

// ── Core Logic ──────────────────────────────────────────────────

let addTypeAliases (content: string) (aliases: Alias list) =
    let mutable result = content
    let mutable addedCount = 0

    // Find insertion point: after the namespace declaration line
    let nsPattern = @"(namespace\s+rec\s+[^\r\n]+)"
    let nsMatch = Regex.Match(result, nsPattern)

    if not nsMatch.Success then
        eprintfn "Warning: Could not find namespace declaration"
        (0, content)
    else
        let insertIdx = nsMatch.Index + nsMatch.Length
        let mutable aliasLines = ""

        for alias in aliases do
            let refFormatted = formatTypeName alias.Reference
            let defFormatted = formatTypeName alias.Definition

            // Check if the reference type is already defined
            let defPattern = sprintf @"^type\s+%s\s*=" (Regex.Escape refFormatted)
            if Regex.IsMatch(result, defPattern, RegexOptions.Multiline) then
                printfn "  Skipping %s — already defined" alias.Reference
            else
                aliasLines <- aliasLines + sprintf "\ntype %s = %s" refFormatted defFormatted
                addedCount <- addedCount + 1

        if addedCount > 0 then
            result <- result.Insert(insertIdx, "\n" + aliasLines)

        (addedCount, result)

// ── Main ────────────────────────────────────────────────────────

let args = fsi.CommandLineArgs |> Array.tail
let config = parseArgs args

printfn "Processing: %s" config.TypesFile
printfn "  Aliases: %d mapping(s)" config.Aliases.Length

if not (File.Exists config.TypesFile) then
    eprintfn "Error: File not found: %s" config.TypesFile
    exit 1

let content = File.ReadAllText(config.TypesFile)

// Idempotency: check if all aliases are already present
let allPresent =
    config.Aliases |> List.forall (fun alias ->
        let refFormatted = formatTypeName alias.Reference
        let defPattern = sprintf @"^type\s+%s\s*=" (Regex.Escape refFormatted)
        Regex.IsMatch(content, defPattern, RegexOptions.Multiline))

if allPresent then
    printfn "Already processed - all type aliases present"
    exit 0

let (addedCount, updated) = addTypeAliases content config.Aliases

if addedCount > 0 then
    File.WriteAllText(config.TypesFile, updated)
    printfn "✓ Added %d type alias(es)" addedCount
else
    printfn "No type aliases needed"
