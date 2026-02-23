open System

let rec first_num num = 
    if num < 10 then
        printfn "Первая цифра - %i" num
    else
        first_num (num/10)

[<EntryPoint>]
let main args = 
    printfn "Введите число"
    let num = int(Console.ReadLine())
    if num > 0 then
        first_num num
    else
        printfn "Вводимое число должно быть натуральным!"
    0