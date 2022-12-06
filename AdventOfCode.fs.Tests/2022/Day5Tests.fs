namespace AdventOfCode.fs.Tests.Year2022

open Xunit
open AdventOfCode.fs.Year2022
open System.IO

module Day5Tests =


    [<Fact>]
    let ``Part 1`` () =

        let report = File.ReadLines("Input/2022/Day5.txt") |> Seq.toList
        Assert.Equal("TBVFVDZPN", Day5.SolvePart1 report)

    [<Fact>]
    let ``Part 2`` () =

        let report = File.ReadLines("Input/2022/Day5.txt") |> Seq.toList
        Assert.Equal("VLCWHTDSZ", Day5.SolvePart2 report)
