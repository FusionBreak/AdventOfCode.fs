namespace AdventOfCode.fs.Year2022

open System.Collections.Generic

module Day5 =

    type procedure = {
        From: int
        To: int
        Count: int
    }
    
    let parseCrates (line:string) =
        [|  line[1]
            line[5]
            line[9]
            line[13]
            line[17]
            line[21]
            line[25]
            line[29]
            line[33]    |]

    let stackCrates crates =
        seq {
            let max = crates |> Seq.head |> Seq.length
            let mutable index = 0

            while index < max do
                yield crates 
                        |> Seq.map (fun row -> row |> Seq.skip index |> Seq.head) 
                        |> Seq.where (fun content -> content <> ' ')
                        |> Seq.toArray

                index <- index+1
        }

    let parseProcedures (line:string) =
        let parts = line.Split ' '
        {
            From = int parts[3]
            To = int parts[5]
            Count = int parts[1]
        }
  
    let move (crateStacks:array<array<char>>) rev procedure =
        let take count crates =
            crates
            |> Seq.take count
            |> Seq.toArray
        let remove count crates =
            crates
            |> Seq.removeManyAt 0 count
            |> Seq.toArray
        let add newCrates crates =
            crates
            |> Seq.append (if rev then (Seq.rev newCrates) else newCrates)
            |> Seq.toArray

        let fromIndex = procedure.From - 1
        let toIndex = procedure.To - 1
        let count = procedure.Count
        let taken = crateStacks[fromIndex] |> take count
        crateStacks[fromIndex] <- crateStacks[fromIndex] |> remove count
        crateStacks[toIndex] <- crateStacks[toIndex] |> add taken 
        crateStacks

    let SolvePart1 input =        
        let procedures = input 
                        |> Seq.skip 10
                        |> Seq.map (fun line -> line |> parseProcedures)
        
        let mutable crateStacks = input 
                                    |> Seq.take 8
                                    |> Seq.map (fun line -> line |> parseCrates)
                                    |> stackCrates
                                    |> Seq.toArray
        
        for procedure in procedures do
            crateStacks <- procedure |> move crateStacks true
        
        crateStacks
        |> Seq.map (fun stack -> stack |> Seq.head)
        |> Seq.toArray
        |> System.String

    let SolvePart2 input =      
        let procedures = input 
                        |> Seq.skip 10
                        |> Seq.map (fun line -> line |> parseProcedures)

        let mutable crateStacks = input 
                                    |> Seq.take 8
                                    |> Seq.map (fun line -> line |> parseCrates)
                                    |> stackCrates
                                    |> Seq.toArray

        for procedure in procedures do
            crateStacks <- procedure |> move crateStacks false

        crateStacks
        |> Seq.map (fun stack -> stack |> Seq.head)
        |> Seq.toArray
        |> System.String