let concatena (l1,l2) =    // l1: 'a list * l2: 'a list -> 'a list
    l1@l2

let add l1 x =  // l1: 'a list -> 'a -> 'a list
    x::l1

open System

[<EntryPoint>]
let main argv =
    let i_list = [1; 2; 3; 4; 5; 6; 7] // int list
    let empty = []  // 'a list
    let f_list = [1.0; 2.0; 12.0; 99.9] // float list
    let c_list = ['c';'i';'a';'o']  // char list
    printfn "Contenuto i_list = %A" i_list
    printfn "Contenuto empty = %A" empty
    printfn "Contenuto f_list = %A" f_list
    printfn "Contenuto c_list = %A" c_list

    // Aggiunta di un int alla lista
    let i_list = add i_list 99
    printfn "Contenuto i_list = %A" i_list

    let empty = add empty 832
    printfn "Contenuto empty = %A" empty

    let con_lists = concatena (i_list,empty)
    printfn "Contenuto con_lists = %A" con_lists

    printfn "Media elementi di f_list = %f" (List.average f_list)

    printfn "Media del doppio dei numeri in f_list = %f" (List.averageBy (fun n -> n*2.0) f_list)

    let l = List.filter (fun n ->n%2.0=0.0) f_list
    printfn "Numeri pari in f_list = %A" l

    printfn "Somma dei numeri pari in f_list = %A" (List.reduce (fun x y -> x+y) l)

    printf "Media dei numeri pari in f_list = %f" (List.average l)

    0
