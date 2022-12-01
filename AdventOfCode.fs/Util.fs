namespace AdventOfCode.fs

module Util =

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

    let withNewIndex input = seq {
        let mutable index = 0
        for element in input do
            yield (index, element)
            index <- index+1
    }

