// Funzione che presa una lista, restituisce la somma dei quadrati di tutti i numeri pari.
// Filter: numeri pari
// Map: x -> x^2
// Reduce: Somma di tutti gli x^2

// Predicate numeri pari
let evenNumber x =  // x: int -> bool
    x%2=0;

// Map quadrato dei numeri
let powNumber x = // x: int -> int
    x*x;

// Reduce
let sum x y =   // x: int -> y: int -> int
    x+y;

let sumPowNumbers list =    // list: int list -> int
    List.reduce (sum) (List.map (powNumber) (List.filter (evenNumber) list ));
 
open System

[<EntryPoint>]
let main argv =
    printfn "Somma dei quadrati dei primi 10 numeri pari = %d" (sumPowNumbers [1 .. 10]);
    0
