#!/usr/bin/env dotnet fsi

// Post-processor: Fix missing separators in F# list expressions.
// Hawaii occasionally generates multiple RequestPart items on a single line
// without a semicolon or newline separator, causing FS0003 errors.
//
// Pattern: `RequestPart.X (...)   RequestPart.Y (...) ]`
// Fix:     Split into separate lines with proper indentation.
//
// Usage:
//   dotnet fsi fix-list-separators.fsx <Client.fs>

open System
open System.IO
open System.Text.RegularExpressions

let args = fsi.CommandLineArgs |> Array.tail

if args.Length = 0 then
    eprintfn "Usage: dotnet fsi fix-list-separators.fsx <Client.fs>"
    exit 1

let filePath = args.[0]

if not (File.Exists filePath) then
    eprintfn "Error: File not found: %s" filePath
    exit 1

printfn "Fix list separators: %s" filePath

let content = File.ReadAllText filePath
let mutable result = content
let mutable count = 0

// Fix: Multiple RequestPart calls on the same line
// Match: `RequestPart.xxx (...)   RequestPart.yyy (...)` (with whitespace between)
// Loop until convergence — a line with 3+ items needs multiple passes
let pattern = @"(RequestPart\.\w+ (?:\([^)]*\)|[a-zA-Z]\w*))[^\S\n]{2,}(RequestPart\.\w+)"
let mutable changed = true
while changed do
    let before = result
    result <- Regex.Replace(result, pattern,
        fun m ->
            count <- count + 1
            sprintf "%s\n                  %s" m.Groups.[1].Value m.Groups.[2].Value)
    changed <- before <> result

if count > 0 then
    File.WriteAllText(filePath, result)
    printfn "  Fixed %d list separator(s)" count
else
    printfn "  No fixes needed"
