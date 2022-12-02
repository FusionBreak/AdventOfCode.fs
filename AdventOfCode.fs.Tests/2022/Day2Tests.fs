namespace AdventOfCode.fs.Tests.Year2022

open Xunit
open AdventOfCode.fs.Year2022
open System.IO

module Day2Tests =


    [<Fact>]
    let ``Part 1`` () =

        let report = File.ReadLines("Input/2022/Day2.txt") |> Seq.toList
        Assert.Equal(12156, Day2.SolvePart1 report)

    [<Fact>]
    let ``Part 2`` () =

        let report = File.ReadLines("Input/2022/Day2.txt") |> Seq.toList
        Assert.Equal(10835, Day2.SolvePart2 report)
