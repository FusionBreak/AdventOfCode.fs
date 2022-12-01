namespace AdventOfCode.fs.Tests.Year2022

open Xunit
open AdventOfCode.fs.Year2022
open System.IO

module Day1Tests =


    [<Fact>]
    let ``Part 1`` () =

        let report = File.ReadLines("Input/2022/Day1.txt") |> Seq.toList
        Assert.Equal(70369, Day1.SolvePart1 report)

    [<Fact>]
    let ``Part 2`` () =

        let report = File.ReadLines("Input/2022/Day1.txt") |> Seq.toList
        Assert.Equal(203002, Day1.SolvePart2 report)
