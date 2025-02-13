module Problem13

open System.IO

let numbersPath = 
    Path.Combine(__SOURCE_DIRECTORY__, "..", "..", "resources", "0013_numbers.txt")


let getNumbers path =
    File.ReadAllLines path 
    |> Array.map (fun line -> bigint.Parse(line.Trim()))


let recursive () =
    let numbers = getNumbers numbersPath
    let sum = numbers |> Array.sum
    sum.ToString().Substring(0, 10) |> int64


let modular () =
    numbersPath
    |> getNumbers
    |> Array.sum
    |> string
    |> fun s -> s.Substring(0, 10)
    |> int64

let solutions = [ recursive; modular ]