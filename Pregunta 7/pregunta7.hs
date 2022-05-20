suma x y = x+y
resta x y = x-y
multi x y = x*y
division x y = x/y

main = do
    putStrLn "Ingrese el primer numero: "
    num1 <- getLine
    putStrLn "Ingrese el segundo numero: "
    num2 <- getLine
    
    let cnum1 = (read num1 :: Int)
    let cnum2 = (read num2 :: Int)
    let dcnum1 = (read num1 :: Float)
    let dcnum2 = (read num2 :: Float)
    
    putStrLn ("La suma entre (" ++ num1 ++ "+" ++ num2 ++ ") resulta: ")
    print (suma cnum1 cnum2)
    putStrLn ("La resta entre (" ++ num1 ++ "-" ++ num2 ++ ") resulta: ")
    print (resta cnum1 cnum2)
    putStrLn ("La multiplicacion entre (" ++ num1 ++ "*" ++ num2 ++ ") resulta: ")
    print (multi cnum1 cnum2)
    putStrLn ("La division entre (" ++ num1 ++ "/" ++ num2 ++ ") resulta: ")
    print (division dcnum1 dcnum2)