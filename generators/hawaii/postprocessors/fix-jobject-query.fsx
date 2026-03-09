#!/usr/bin/env dotnet fsi

// Post-processor: Fix incompatible query parameter types in Client.fs.
// Hawaii generates parameters with types that don't match any
// RequestPart.query overload:
//   - list<Newtonsoft.Json.Linq.JObject> (JObject lists)
//   - list<EnumForX> aliases (enum list type aliases from Types.fs)
//
// Fix: Change these parameter types to `string` since query parameters
// should be serialized as strings anyway.
//
// Usage:
//   dotnet fsi fix-jobject-query.fsx <Client.fs> [<Types.fs>]

open System
open System.IO
open System.Text.RegularExpressions

let args = fsi.CommandLineArgs |> Array.tail

if args.Length = 0 then
    eprintfn "Usage: dotnet fsi fix-jobject-query.fsx <Client.fs> [<Types.fs>]"
    exit 1

let clientFile = args.[0]
let typesFile = if args.Length > 1 then Some args.[1] else None

if not (File.Exists clientFile) then
    eprintfn "Error: File not found: %s" clientFile
    exit 1

printfn "Fix query params: %s" clientFile

let mutable result = File.ReadAllText clientFile
let mutable count = 0

// Fix 1: JObject list parameters
result <- Regex.Replace(result,
    @"\?(\w+):\s*list<Newtonsoft\.Json\.Linq\.JObject>",
    fun m ->
        count <- count + 1
        printfn "  JObject list -> string: %s" m.Groups.[1].Value
        sprintf "?%s: string" m.Groups.[1].Value)

// Fix 2: Enum list type aliases from Types.fs
// Find types defined as `type X = list<EnumForY>` and replace usages in Client.fs
match typesFile with
| Some tf when File.Exists tf ->
    let typesContent = File.ReadAllText tf
    let enumListPattern = @"type\s+(``[^`]+``|\w+)\s*=\s*list<\s*(?:``[^`]+``|EnumFor\w+)\s*>"
    for m in Regex.Matches(typesContent, enumListPattern) do
        let typeName = m.Groups.[1].Value
        // Replace in parameter declarations: ?paramName: TypeName -> ?paramName: string
        let paramPattern = sprintf @"(\?\w+:\s*)%s(?=[\s,)])" (Regex.Escape typeName)
        result <- Regex.Replace(result, paramPattern, fun pm ->
            count <- count + 1
            printfn "  Enum list -> string: %s (%s)" typeName pm.Groups.[1].Value
            sprintf "%sstring" pm.Groups.[1].Value)
| _ -> ()

if count > 0 then
    File.WriteAllText(clientFile, result)
    printfn "  Fixed %d query parameter type(s)" count
else
    printfn "  No fixes needed"
