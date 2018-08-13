#r "paket:
nuget Fake.Core.Target
nuget Fake.IO.FileSystem //"
#load "./.fake/tryscript.fsx/intellisense.fsx"

open Fake.IO
open Fake.IO.Globbing
open Fake.IO.Globbing.Operators
let files = !! "files/a*.txt"

// for file in files do
//     printfn "File: %s" file // works

files
    |> Seq.iter (fun x -> printfn "File: %s" x)
