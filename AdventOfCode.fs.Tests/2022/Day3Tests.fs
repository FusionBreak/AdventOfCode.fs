namespace AdventOfCode.fs.Tests.Year2022

open Xunit
open AdventOfCode.fs.Year2022
open System.IO

module Day3Tests =


    [<Fact>]
    let ``Part 1`` () =

        let report = File.ReadLines("Input/2022/Day3.txt") |> Seq.toList
        Assert.Equal(8202, Day3.SolvePart1 report)

    [<Fact>]
    let ``Part 2`` () =

        let report = File.ReadLines("Input/2022/Day3.txt") |> Seq.toList
        Assert.Equal(2864, Day3.SolvePart2 report)
