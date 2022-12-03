namespace AdventOfCode.fs.Year2022

open System

module Day3 =

    let toPoints (letter:char) =
            if Char.IsLower letter then
                int letter - 96
            else
                int letter - 38

    let SolvePart1 input =
        let halveRow (input:string) =
            let mid = input.Length / 2
            (input[..mid-1], input[mid..])

        let findDuplicate ((head:string), (tail:string)) : char =
            head
            |> Seq.where (fun letter -> tail.Contains(letter))
            |> Seq.head

        input
        |> Seq.map (fun row -> halveRow row)
        |> Seq.map (fun rowHalves -> findDuplicate rowHalves)
        |> Seq.map (fun duplicate -> toPoints duplicate)
        |> Seq.sum


    let SolvePart2 input =
        let findDuplicate (rows:seq<string>) =
            let first = rows |> Seq.head
            let second = rows |> Seq.skip 1 |> Seq.head
            let third = rows |> Seq.skip 2 |> Seq.head
            
            first
            |> Seq.where (fun letter -> second.Contains(letter) && third.Contains(letter))
            |> Seq.head

        input
        |> Seq.chunkBySize 3
        |> Seq.map (fun chunk -> findDuplicate chunk)
        |> Seq.map (fun duplicate -> toPoints duplicate)
        |> Seq.sum
            
