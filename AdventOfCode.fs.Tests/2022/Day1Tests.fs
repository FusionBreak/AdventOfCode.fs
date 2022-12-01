namespace AdventOfCode.fs.Tests.Year2022

open Xunit
open AdventOfCode.fs.Year2022

module Day1Tests =

    [<Fact>]
    let ``Part 1`` () =

        let report =  [ "1000"; "2000"; "3000"; ""; "4000"; ""; "5000"; "6000"; ""; "7000"; "8000"; "9000"; ""; "10000"; ]
        Assert.Equal(24000, Day1.SolvePart1 report)

