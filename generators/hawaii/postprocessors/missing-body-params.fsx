#!/usr/bin/env dotnet fsi

// Generalized post-processor for missing body parameters.
// Some Hawaii-generated methods omit a required body parameter from
// PUT/POST endpoints. This script adds the body parameter to the
// method signature and a RequestPart.jsonContent entry to the
// request parts list.
//
// Usage:
//   dotnet fsi missing-body-params.fsx <Client.fs> --method-name <name> --body-type <type>
//
// Example:
//   dotnet fsi missing-body-params.fsx Generated-Workers/Client.fs \
//     --method-name WorkerPutScriptSecret \
//     --body-type Types.workersbindingkindsecrettext

open System
open System.IO
open System.Text.RegularExpressions

// ── Argument Parsing ─────────────────────────────────────────────

type Config =
    { ClientFile: string
      MethodName: string
      BodyType: string }

let parseArgs (args: string[]) =
    let mutable clientFile = ""
    let mutable methodName = ""
    let mutable bodyType = ""
    let mutable i = 0

    while i < args.Length do
        match args.[i] with
        | "--method-name" when i + 1 < args.Length ->
            methodName <- args.[i + 1]
            i <- i + 2
        | "--body-type" when i + 1 < args.Length ->
            bodyType <- args.[i + 1]
            i <- i + 2
        | s when not (s.StartsWith("--")) && clientFile = "" ->
            clientFile <- s
            i <- i + 1
        | other ->
            eprintfn "Unknown argument: %s" other
            exit 1

    if clientFile = "" || methodName = "" || bodyType = "" then
        eprintfn "Usage: dotnet fsi missing-body-params.fsx <Client.fs> --method-name <name> --body-type <type>"
        exit 1

    { ClientFile = clientFile
      MethodName = methodName
      BodyType = bodyType }

// ── Core Logic ──────────────────────────────────────────────────

let addBodyParameter (content: string) (config: Config) =
    // Step 1: Find the method signature and add the body parameter
    //   member this.MethodName(params, ?cancellationToken: CancellationToken)
    //   → member this.MethodName(params, body: BodyType, ?cancellationToken: CancellationToken)
    let sigPattern =
        sprintf @"(member this\.%s\([^)]*?)(\?cancellationToken:\s*CancellationToken\))"
            (Regex.Escape config.MethodName)

    let mutable updated = content
    let mutable changed = false

    if Regex.IsMatch(updated, sigPattern) then
        updated <- Regex.Replace(updated, sigPattern,
            sprintf "$1body: %s, $2" config.BodyType)
        changed <- true
    else
        eprintfn "Warning: Could not find method signature for %s" config.MethodName

    // Step 2: Add RequestPart.jsonContent body to the requestParts list
    // Find the method's requestParts list and append the body part.
    // Pattern: within the method, find the closing bracket of requestParts
    // and insert RequestPart.jsonContent body before it.
    //
    // We look for the pattern:
    //   member this.MethodName(...) =
    //       async {
    //           let requestParts =
    //               [ ... last entry ]
    //
    // And insert RequestPart.jsonContent body as an additional entry.

    let bodyPartPattern =
        sprintf @"(member this\.%s\([^)]+\)\s*=\s*async\s*\{\s*let requestParts\s*=\s*\[[^\]]*)(])"
            (Regex.Escape config.MethodName)

    if Regex.IsMatch(updated, bodyPartPattern, RegexOptions.Singleline) then
        updated <- Regex.Replace(updated, bodyPartPattern,
            "$1  RequestPart.jsonContent body $2",
            RegexOptions.Singleline)
        changed <- true
    else
        // If the method was already modified in step 1, warn about step 2
        if changed then
            eprintfn "Warning: Added body to signature but could not locate requestParts for %s" config.MethodName

    (changed, updated)

// ── Main ────────────────────────────────────────────────────────

let args = fsi.CommandLineArgs |> Array.tail
let config = parseArgs args

printfn "Processing: %s" config.ClientFile
printfn "  method-name: %s" config.MethodName
printfn "  body-type:   %s" config.BodyType

if not (File.Exists config.ClientFile) then
    eprintfn "Error: File not found: %s" config.ClientFile
    exit 1

let content = File.ReadAllText(config.ClientFile)

// Idempotency check: if the method already has `body:` in its signature, skip
let idempotencyPattern =
    sprintf @"member this\.%s\([^)]*body:" (Regex.Escape config.MethodName)

if Regex.IsMatch(content, idempotencyPattern) then
    printfn "Already processed - body parameter found in %s" config.MethodName
    exit 0

let (changed, updated) = addBodyParameter content config

if changed then
    File.WriteAllText(config.ClientFile, updated)
    printfn "✓ Added body parameter (%s) to %s" config.BodyType config.MethodName
else
    printfn "No changes needed for %s" config.MethodName
