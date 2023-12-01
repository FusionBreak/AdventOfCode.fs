namespace AdventOfCode.fs.Tests.Year2023

open Xunit
open AdventOfCode.fs.Year2023
open System.IO

module Day1Tests =


    [<Fact>]
    let ``Part 1`` () =
        let report = File.ReadLines("Input/2023/Day1.txt") |> Seq.toList
        Assert.Equal(54304, Day1.solvePart1 report)

    [<Fact>]
    let ``Part 2`` () =
        let report = File.ReadLines("Input/2023/Day1.txt") |> Seq.toList
        Assert.Equal(53892, Day1.solvePart2 report)
