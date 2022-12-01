namespace AdventOfCode.fs.Year2022

open AdventOfCode.fs.Util

module Day1 =

    let SolvePart1 (input: list<string>) =
        
        input 
        |> splitByChar ""
        |> Seq.map (fun strings -> strings |> toNumbers |> Seq.sum)
        |> Seq.toList
        |> List.sortDescending
        |> List.head

    let SolvePart2 (input: list<string>) =
        
        input 
        |> splitByChar ""
        |> Seq.map (fun strings -> strings |> toNumbers |> Seq.sum)
        |> Seq.toList
        |> List.sortDescending
        |> List.take 3
        |> List.sum