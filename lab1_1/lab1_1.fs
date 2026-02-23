open System

let items count = 
    let numbers = [for i in 0..count-1 -> pown 2 i]
    printfn "%A" numbers


[<EntryPoint>]
let main args = 
    printfn "Введите кол-во чисел"
    let count = int(Console.ReadLine())
    if count > 0 then
        items count
    else
        printfn "Кол-во чисел должно быть больше 0!"
    0