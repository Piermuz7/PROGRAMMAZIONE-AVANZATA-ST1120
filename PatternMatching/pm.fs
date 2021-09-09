let rec conta l =   // conta: l: float list -> float
    match l with
    | [] -> 0.0
    | v::tail -> v + (conta tail)


let isVocal v =
    if(v='a' || v='e' || v='i' || v='o' || v='u') then true
    else false

let rec contaVocali s vocali= 
    match s with
    | [] -> 0
    | v::tail -> if(isVocal v) 
                 then contaVocali tail vocali+1
                 else
                      contaVocali tail vocali

open System

[<EntryPoint>]
let main argv =
    printfn "Somma della lista = %f" (conta [1.0 .. 10.0])
    printfn "Numero vocali di aiuola = %d" (contaVocali ['a';'i';'u';'o';'l';'a'] 0)
    printfn "Numero vocali di Piermuz = %d" (contaVocali ['P';'i';'e';'r';'m';'u';'z'] 0)
    0
