namespace AdventOfCode.fs.Tests.Year2021

open System
open Xunit
open AdventOfCode.fs.Year2021

module Day1Tests =

    [<Fact>]
    let ``Part 1`` () =
    
        let report =  [ 199; 200; 208; 210; 200; 207; 240; 269; 260; 263 ]
        Assert.Equal(7, Day1.SolvePart1 report)

    [<Fact>]
    let ``Part 2`` () =
    
        let report =  [ 199; 200; 208; 210; 200; 207; 240; 269; 260; 263 ]
        Assert.Equal(5, Day1.SolvePart2 report)
