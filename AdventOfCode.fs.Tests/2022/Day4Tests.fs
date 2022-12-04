namespace AdventOfCode.fs.Tests.Year2022

open Xunit
open AdventOfCode.fs.Year2022
open System.IO

module Day4Tests =


    [<Fact>]
    let ``Part 1`` () =

        let report = File.ReadLines("Input/2022/Day4.txt") |> Seq.toList
        Assert.Equal(571, Day4.SolvePart1 report)

    [<Fact>]
    let ``Part 2`` () =

        let report = File.ReadLines("Input/2022/Day4.txt") |> Seq.toList
        Assert.Equal(917, Day4.SolvePart2 report)
