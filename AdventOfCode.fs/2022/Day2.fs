namespace AdventOfCode.fs.Year2022

open AdventOfCode.fs.Util

module Day2 =

    type Shape =
        | Rock //1
        | Paper //2
        | Scissors //3

    type Round = Round of Me:Shape * Opponent:Shape

    let calculateRound = function
        | Round(Rock, Scissors) -> 7        //win
        | Round(Paper, Rock) -> 8           //win
        | Round(Scissors, Paper) -> 9       //win
        | Round(Rock, Rock) -> 4            //draw
        | Round(Paper, Paper) -> 5          //draw
        | Round(Scissors, Scissors) -> 6    //draw
        | Round(Rock, Paper) -> 1           //lose
        | Round(Paper, Scissors) -> 2       //lose
        | Round(Scissors, Rock) -> 3        //lose


    let SolvePart1 input =
        
        let parseRow (row:string) =
            let convert = function
                | 'A' | 'X' -> Rock
                | 'B' | 'Y' -> Paper
                | 'C' | 'Z' -> Scissors
                | unkown -> failwith $"Unkown letter: {unkown}."
            let opponent = convert row[0]
            let me = convert row[2]
            Round(me, opponent)
        
        input
        |> Seq.map (fun row -> parseRow row)
        |> Seq.map (fun round -> calculateRound round)
        |> Seq.sum


    let SolvePart2 input =
        
        let parseRow (row:string) =
            let convertOpponent = function
                | 'A' -> Rock
                | 'B' -> Paper
                | 'C' -> Scissors
                | unkown -> failwith $"Unkown letter: {unkown}."
            let convertMe letter opponent =
                match (letter, opponent) with
                | ('X', Rock) -> Scissors
                | ('X', Paper) -> Rock
                | ('X', Scissors) -> Paper
                | ('Y', Rock) -> Rock
                | ('Y', Paper) -> Paper
                | ('Y', Scissors) -> Scissors
                | ('Z', Rock) -> Paper
                | ('Z', Paper) -> Scissors
                | ('Z', Scissors) -> Rock
                | _ -> failwith $"Unkown letter."
            let opponent = convertOpponent row[0]
            let me = convertMe row[2] opponent
            Round(me, opponent)
        
        input
        |> Seq.map (fun row -> parseRow row)
        |> Seq.map (fun round -> calculateRound round)
        |> Seq.sum