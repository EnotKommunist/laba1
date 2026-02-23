open System

let summa a1 b1 a2 b2 = 
    [
        let a = float(a1 + a2)
        let b = float(b1 + b2)
        if b = 0 then
            printfn "Сумма: %f" a
        elif b > 0 then
            printfn "Сумма: %f + %fb" a b
        else
            printfn "Сумма: %f - %fb" a (-1. * b)
    ]

let raznost a1 b1 a2 b2 = 
    let a = a1 - a2
    let b = b1 - b2
    if b = 0.0 then
        printfn "Разность: %f" a
    elif b > 0.0 then
        printfn "Разность: %f + %fi" a b
    else
        printfn "Разность: %f - %fi" a (-b)

let proizvedenie a1 b1 a2 b2 = 
    // (a1 + b1i)(a2 + b2i) = (a1*a2 - b1*b2) + (a1*b2 + b1*a2)i
    let a = a1 * a2 - b1 * b2
    let b = a1 * b2 + b1 * a2
    if b = 0.0 then
        printfn "Произведение: %f" a
    elif b > 0.0 then
        printfn "Произведение: %f + %fi" a b
    else
        printfn "Произведение: %f - %fi" a (-b)

let delenie a1 b1 a2 b2 = 
    if a2 = 0.0 && b2 = 0.0 then
        printfn "Ошибка: деление на ноль невозможно"
    else
        let znamenatel = a2 * a2 + b2 * b2
        let a = (a1 * a2 + b1 * b2) / znamenatel
        let b = (b1 * a2 - a1 * b2) / znamenatel
        if b = 0.0 then
            printfn "Частное: %f" a
        elif b > 0.0 then
            printfn "Частное: %f + %fi" a b
        else
            printfn "Частное: %f - %fi" a (-b)

[<EntryPoint>]
let main args = 
    printfn "Введите значения a и b для первого комплексного числа a + bi"
    printf "a1 = "
    let a1 = float(Console.ReadLine())
    printf "b1 = "
    let b1 = float(Console.ReadLine())
    printfn "Введите значения a и b для второго комплексного числа a + bi"
    printf "a2 = "
    let a2 = float(Console.ReadLine())
    printf "b2 = "
    let b2 = float(Console.ReadLine())
    printfn "\nРезультаты операций:"
    printfn "-------------------"
    summa a1 b1 a2 b2
    raznost a1 b1 a2 b2
    proizvedenie a1 b1 a2 b2
    delenie a1 b1 a2 b2
    0