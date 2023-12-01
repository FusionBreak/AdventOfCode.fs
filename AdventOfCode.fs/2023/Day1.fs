namespace AdventOfCode.fs.Year2023

open System

module Day1 =
    type namedNumber = {
        Name: string
        Number: int
    }
    
    let allNamedNumbers = 
        [|
            { Name = "zero"; Number = 0 }
            { Name = "one"; Number = 1 }
            { Name = "two"; Number = 2 }
            { Name = "three"; Number = 3 }
            { Name = "four"; Number = 4 }
            { Name = "five"; Number = 5 }
            { Name = "six"; Number = 6 }
            { Name = "seven"; Number = 7 }
            { Name = "eight"; Number = 8 }
            { Name = "nine"; Number = 9 }
        |]

    let allallNamedNumbersReversed = 
        allNamedNumbers
        |> Array.rev
    
    let replaceAllNamesToNumbers (input: string) =
        let mutable result = input
        for namedNumber in allallNamedNumbersReversed do
            result <- result.Replace(namedNumber.Name, namedNumber.Number.ToString())
        result
    
    let firstAndLast seq = 
        Seq.head seq, Seq.last seq

    let combineFirstAndLastDigit (first, last) = 
        let first = int (first - '0')
        let last = int (last - '0')
        first * 10 + last

    let getCoordinate (input: string) =
        input
        |> Seq.where Char.IsDigit
        |> firstAndLast
        |> combineFirstAndLastDigit

    let solvePart1 input =
        input
        |> Seq.map getCoordinate
        |> Seq.sum

    let solvePart2 input =
        input
        |> Seq.map replaceAllNamesToNumbers
        |> Seq.map getCoordinate
        |> Seq.toList
        |> Seq.sum
        
        

