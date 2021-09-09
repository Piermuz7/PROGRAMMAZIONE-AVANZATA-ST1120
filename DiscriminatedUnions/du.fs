// Learn more about F# at http://fsharp.org

type Persona =
    | Nome of string
    | Cognome of string
    | Eta of int

let query nome =
    match nome with 
    | Nome(name) -> printfn"Ti chiami %s?" name
    | Cognome(surname) -> printfn"Il tuo cognome è %s?" surname
    | Eta(age) -> printfn"Età = %d?" age

type Shape =
    | Rectangle of width: float * height: float
    | Circle of radius: float
    | Prism of width: float * float * height: float

let matchShape shape =
    match shape with
    | Rectangle(width = w; height = h) -> printfn "Rettangolo avente base=%f e altezza=%f" w h
    | Circle(r) -> printfn "Cerchio avente raggio=%f" r

open System

[<EntryPoint>]
let main argv =
    let n = Nome "Piermichele"
    let c = Cognome "Rosati"
    let e = Eta 21
    query n
    query c
    query e

    let rect = Rectangle (2.0,4.0)
    let cerchio = Circle(7.7)
    matchShape rect
    matchShape cerchio
    0 // return an integer exit code
