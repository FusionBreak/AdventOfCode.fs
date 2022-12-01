namespace AdventOfCode.fs.Year2022

open AdventOfCode.fs.Util

module Day1 =

    let SolvePart1 (input: list<string>) =
        
        let elves = input 
                    |> splitByChar ""
                    |> Seq.map (fun strings -> strings |> toNumbers)

        elves 
        |> Seq.map (fun calories -> calories |> Seq.sum)
        |> withNewIndex
        |> Seq.toList
        |> List.sortByDescending (fun (key, value) -> value)
        |> List.map (fun (key, value) -> value)
        |> List.head