#!/usr/bin/env dotnet fsi

// Post-processor for $-prefixed identifiers in Hawaii-generated F# code.
// Hawaii emits bare $-prefixed names (e.g. $metadata) as parameters in
// static member Create methods, which is invalid F#. This script wraps
// them in double-backtick quoting so they compile correctly.
//
// Usage:
//   dotnet fsi fix-dollar-identifiers.fsx <Types.fs>
//
// Transforms:
//   static member Create (($metadata): ``$metadata``, ...)
//     { ``$metadata`` = $metadata ... }
// Into:
//   static member Create ((``$metadata``): ``$metadata``, ...)
//     { ``$metadata`` = ``$metadata`` ... }

open System
open System.IO
open System.Text.RegularExpressions

// ── Core Logic ──────────────────────────────────────────────────

let fixDollarIdentifiers (content: string) =
    let mutable result = content
    let mutable changeCount = 0

    // Fix 1: Parameter patterns like ($name) → (``$name``)
    // Matches: (($identifier): or ($identifier):
    // where $identifier is a bare dollar-prefixed name (not already backtick-quoted)
    let paramPattern = @"\((\$[a-zA-Z_][a-zA-Z0-9_]*)\)"
    result <- Regex.Replace(result, paramPattern, fun m ->
        let name = m.Groups.[1].Value
        changeCount <- changeCount + 1
        sprintf "(``%s``)" name)

    // Fix 2: Bare $name on the right side of record field assignments
    // Matches: = $identifier (end of line or followed by whitespace/comma/semicolon)
    // But NOT already backtick-quoted: = ``$identifier``
    let assignPattern = @"(=\s+)(\$[a-zA-Z_][a-zA-Z0-9_]*)(\s|$|;)"
    result <- Regex.Replace(result, assignPattern, fun m ->
        let prefix = m.Groups.[1].Value
        let name = m.Groups.[2].Value
        let suffix = m.Groups.[3].Value
        changeCount <- changeCount + 1
        sprintf "%s``%s``%s" prefix name suffix)

    (changeCount, result)

// ── Main ────────────────────────────────────────────────────────

let args = fsi.CommandLineArgs |> Array.tail

if args.Length = 0 then
    eprintfn "Usage: dotnet fsi fix-dollar-identifiers.fsx <path-to-Types.fs>"
    exit 1

let typesFile = args.[0]
printfn "Processing: %s" typesFile

if not (File.Exists typesFile) then
    eprintfn "Error: File not found: %s" typesFile
    exit 1

let content = File.ReadAllText(typesFile)

// Idempotency check: if no bare $identifiers remain (all are backtick-quoted), skip
if not (Regex.IsMatch(content, @"\(\$[a-zA-Z_]")) then
    printfn "Already processed - no bare $-prefixed parameters found"
    exit 0

let (changeCount, updated) = fixDollarIdentifiers content

if changeCount > 0 then
    File.WriteAllText(typesFile, updated)
    printfn "✓ Fixed %d bare $-prefixed identifier(s)" changeCount
else
    printfn "No $-prefixed identifier issues found"
