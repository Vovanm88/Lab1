module Tests

open System
open Xunit

[<Fact>]
let ``My test`` () = Assert.True(true)

[<Fact>]
let ``Check Problem 13`` () =
    Problem13.solutions
    |> List.iter (fun solution ->
        let res: int64 = solution ()
        Assert.Equal(res, 5537376230))

[<Fact>]
let ``Check Problem 18`` () =
    Problem18.solutions
    |> List.iter (fun solution ->
        let res: int = solution ()
        Assert.Equal(res, 1074))
