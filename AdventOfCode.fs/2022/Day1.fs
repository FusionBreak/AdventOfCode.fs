namespace AdventOfCode.fs.Year2022

module Day1 =

    let toNumbers (input: seq<string>) = input |> Seq.map (fun text -> text |> int)

    let splitByChar character (input:list<'a>) = seq {
        let mutable index = 0;

        while index < input.Length do
            let chunk = 
                input 
                |> Seq.skip index 
                |> Seq.takeWhile (fun e -> e <> character) 
                |> Seq.toList

            index <- index + chunk.Length + 1
            yield chunk
    }

    let SolvePart1 input =
        input
        |> splitByChar ""
        |> Seq.map (fun strings -> strings |> toNumbers |> Seq.sum)
        |> Seq.toList
        |> List.sortDescending
        |> List.head

    let SolvePart2 input =
        input
        |> splitByChar ""
        |> Seq.map (fun strings -> strings |> toNumbers |> Seq.sum)
        |> Seq.toList
        |> List.sortDescending
        |> List.take 3
        |> List.sum