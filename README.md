## Reto 1: Fibonacci
Los números de Fibonacci 𝐹𝐾 son una sucesión de números naturales definidos de la siguiente manera:

``````mathematica
F0 = 0,
f1 = 1,
fk = fk-1 + fk-2,       where k >= 2
``````

En palabras simples, la sucesión de Fibonacci comienza con 0 y 1, y los siguientes términos siempre son la suma de los dos anteriores.
En la siguiente tabla, podemos ver los números de Fibonacci desde el 0-ésimo hasta el duodécimo

``````
n                 0   1   2   3   4   5   6   7   8   9   10   11   12   ...
-------------------------------------------------------------------------------
Fn				  0   1   1   2   3   5	  8   13  21  34  55   89   144  ...
``````

### 1.Escriba un programa que reciba como entrada un número entero n, y entregue como salida el n-ésimo número de Fibonacci
```mathematica
Ingrese n: 11
F11 = 89
```
### 2. Escriba un programa que reciba como entrada un número entero e indique si es o no un número de Fibonacci
```mathematica
Ingrese un numero: 34 
34 es numero de Fibonacci
```
```mathematica
Ingrese un numero: 78 
78 no es numero de Fibonacci
```
### 3. Escriba un programa que muestres los m primeros números de Fibonacci, donde m es un número ingresado por el usuario
```math
Ingrese m: 7
Los 7 primeros numeros de Fibonacci son:
0 1 1 2 3 5 8
```