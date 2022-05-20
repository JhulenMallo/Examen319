// Learn more about F# at http://fsharp.org

open System

let suma x y = x + y

let resta x y = x - y

let multi x y = x * y

let division x y = x / y

[<EntryPoint>]
let main argv =
    
    Console.WriteLine("Ingrese el primer numero: ")
    let num1 = Console.ReadLine()
    Console.WriteLine("Ingrese el segundo numero: ")
    let num2 = Console.ReadLine()

    let cnum1 = Convert.ToInt32(num1)
    let cnum2 = Convert.ToInt32(num2)
    let dcnum1 = Convert.ToDecimal(cnum1)
    let dcnum2 = Convert.ToDecimal(cnum2)

    let opesuma = suma cnum1 cnum2
    let operesta = resta cnum1 cnum2
    let opemulti = multi cnum1 cnum2
    let opedivis = division dcnum1 dcnum2

    Console.WriteLine("La suma ("+num1+" + "+num2+") resulta: "+opesuma.ToString())
    Console.WriteLine("La resta ("+num1+" - "+num2+") resulta: "+operesta.ToString())
    Console.WriteLine("La multiplicacion ("+num1+" * "+num2+") resulta: "+opemulti.ToString())
    Console.WriteLine("La division ("+num1+" / "+num2+") resulta: "+opedivis.ToString())

    0 // return an integer exit code
