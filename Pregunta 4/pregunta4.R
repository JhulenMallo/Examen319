colores = c("rojo", "negro")
coloresamp = c(rep(colores, rep(26, 2)))

numeros = c("A", 2:10, "J", "Q", "K")
numerosamp = (rep(numeros, 4))

simbolos = c("♥", "♦", "♣", "♠")
simbolosamp = c(rep(simbolos, rep(13, 4)))

mi_dataframe <- data.frame(
  "Colores"=coloresamp, 
  "Numeros"=numerosamp, 
  "Simbolos"=simbolosamp)

mi_dataframe
