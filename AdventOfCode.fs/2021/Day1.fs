namespace AdventOfCode.fs.Year2021

module Day1 =
    open System.Collections.Generic
    open System.Linq 

    let SolvePart1 report =
        
        let mutable increases = 0
        let mutable pre = 0

        for value in report do
            if value > pre && pre > 0 
            then increases <- increases+1
            pre <- value
        
        increases


    let SolvePart2 (report: list<int>) =
        
        let sums = new List<int>()

        report
        |> Seq.iteri (fun index current ->
            let sum = current + report.Skip(index+1).FirstOrDefault() + report.Skip(index+2).FirstOrDefault()
            sums.Add(sum)
        )

        SolvePart1(sums)