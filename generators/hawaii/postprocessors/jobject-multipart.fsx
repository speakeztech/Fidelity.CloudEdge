#!/usr/bin/env dotnet fsi

// Generalized post-processor for JObject multipart form data.
// Hawaii generates RequestPart.multipartFormData calls with JObject parameters,
// but there is no overload accepting JObject directly. This converts JObject
// values to their string representation.
//
// Usage:
//   dotnet fsi jobject-multipart.fsx <Client.fs>
//
// No service-specific configuration needed; the script scans for all
// RequestPart.multipartFormData calls where the value is a known JObject
// parameter name and applies .ToString(Newtonsoft.Json.Formatting.None).

open System
open System.IO
open System.Text.RegularExpressions

// ── Core Logic ──────────────────────────────────────────────────

/// Match any RequestPart.multipartFormData ("paramName", paramName) where
/// the value identifier matches the field name (Hawaii's default pattern
/// for JObject-typed parameters).
let fixJObjectMultipart (content: string) =
    // Pattern: RequestPart.multipartFormData ("someName", someName)
    // where someName appears as both the string literal and the value identifier.
    // We add .ToString(Newtonsoft.Json.Formatting.None) to the value.
    let pattern =
        @"RequestPart\.multipartFormData\s*\(\s*""([a-zA-Z_][a-zA-Z0-9_]*)"",\s*(\1)\s*\)"

    let mutable changeCount = 0

    let result =
        Regex.Replace(content, pattern, fun m ->
            let paramName = m.Groups.[1].Value
            let valueName = m.Groups.[2].Value
            // Only fix if not already converted
            if m.Value.Contains(".ToString(") then
                m.Value
            else
                changeCount <- changeCount + 1
                sprintf "RequestPart.multipartFormData (\"%s\", %s.ToString(Newtonsoft.Json.Formatting.None))"
                    paramName valueName)

    (changeCount, result)

// ── Main ────────────────────────────────────────────────────────

let args = fsi.CommandLineArgs |> Array.tail

if args.Length = 0 then
    eprintfn "Usage: dotnet fsi jobject-multipart.fsx <path-to-Client.fs>"
    exit 1

let clientFile = args.[0]
printfn "Processing: %s" clientFile

if not (File.Exists clientFile) then
    eprintfn "Error: File not found: %s" clientFile
    exit 1

let content = File.ReadAllText(clientFile)

// Idempotency check
if content.Contains(".ToString(Newtonsoft.Json.Formatting.None)") then
    printfn "Already processed - JObject fix found"
    exit 0

let (changeCount, updated) = fixJObjectMultipart content

if changeCount > 0 then
    File.WriteAllText(clientFile, updated)
    printfn "✓ Fixed %d JObject multipart form data call(s)" changeCount
else
    printfn "No JObject multipart issues found"
