namespace AdventOfCode.fs.Year2022

open System

module Day4 =

    let parse (row:string) =
        row.Split ','
        |> Seq.map (fun part ->
                        let numbers =part.Split '-'
                        (int numbers[0], int numbers[1])
                    )
    
    let isInRange slice number =
            slice |> Seq.contains number

    let containsCompletely a b =
        let (aFirst, aLast) = a
        let (bFirst, bLast) = b
        aFirst >= bFirst && aLast <= bLast || bFirst >= aFirst && bLast <= aLast

    let overlaps a b =
        let (aFirst, aLast) = a
        let (bFirst, bLast) = b
        aFirst |> isInRange [bFirst..bLast] || aLast |> isInRange [bFirst..bLast] 
        ||
        bFirst |> isInRange [aFirst..aLast] || bLast |> isInRange [aFirst..aLast]
        
    let SolvePart1 input =
        input
        |> Seq.map (fun row -> parse row)
        |> Seq.map (fun parts -> containsCompletely (parts |> Seq.head) (parts |> Seq.last))
        |> Seq.where (fun result -> result)
        |> Seq.length

    let SolvePart2 input =
        input
        |> Seq.map (fun row -> parse row)
        |> Seq.map (fun parts -> overlaps (parts |> Seq.head) (parts |> Seq.last))
        |> Seq.where (fun result -> result)
        |> Seq.length