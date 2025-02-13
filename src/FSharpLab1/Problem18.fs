module Problem18

open System.IO

let trianglePath = 
    Path.Combine(__SOURCE_DIRECTORY__, "..", "..", "resources", "0018_triangle.txt")

let getTriangle path =
    File.ReadAllLines path
    |> Array.map (fun line -> 
        line.Split(' ') 
        |> Array.map int)

let recursive () =
    let triangle = getTriangle trianglePath
    
    let rec findMax row col =
        if row >= Array.length triangle then 0
        else
            let current = triangle.[row].[col]
            let left = findMax (row + 1) col
            let right = findMax (row + 1) (col + 1)
            current + max left right
            
    findMax 0 0

let dynamic () =
    let triangle = getTriangle trianglePath
    let mutable dp = Array.copy (triangle.[Array.length triangle - 1])
    
    for row = (Array.length triangle - 2) downto 0 do
        let mutable newRow = Array.zeroCreate (row + 1)
        for col = 0 to row do
            newRow.[col] <- triangle.[row].[col] + max dp.[col] dp.[col + 1]
        dp <- newRow
        
    dp.[0]

let functional () =
    let triangle = getTriangle trianglePath
    
    triangle
    |> Array.rev
    |> Array.reduce (fun lower upper ->
        Array.init (Array.length upper) (fun i ->
            upper.[i] + max lower.[i] lower.[i + 1]))
    |> Array.head

let sequence () =
    let triangle = getTriangle trianglePath
    
    let folder currentRow previousRow =
        Seq.zip3 
            (Seq.append currentRow (seq { yield 0 }))
            (Seq.append (seq { yield 0 }) currentRow)
            previousRow
        |> Seq.map (fun (left, right, value) -> max left right + value)
        |> Seq.toArray
        
    triangle
    |> Array.rev
    |> Array.reduce folder
    |> Array.head

let solutions = [ recursive; dynamic; functional; sequence ]