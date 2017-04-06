module Program
open System

// 'a means generic 
let rec last(l : 'a list) = 
 match l with
    | [] -> failwith "You cannot use last with an empty list"
    | [x] -> x
    | x :: xs -> last xs


let rec lastButOne (l : 'a list) = 
 match l with 
    | [x;_] -> x 
    | x :: xs -> lastButOne xs
    | _ -> failwith "List should have at least 2 elements"


let rec nth (index : int) (l: 'a list) =
    match l with
    | [] -> failwith "index out of bound"
    | x :: xs ->
        if index = 1 then
          x
        else
         nth (index - 1) xs
   // nth 2 [1;2;3;4;9]

let rec length (l : 'a list) =
    match l with 
    |[] -> 0
    | x :: xs -> 1 + (length xs)


let tailLength (l : 'a list) =
    let rec tailCall (l : 'a list) (counter : int) =
        match l with
        | [] -> counter
        | x :: xs -> tailCall xs (counter + 1)
    tailCall l 0


// length with fold function
let foldLength (l : 'a list) =
    List.fold (fun counter x -> counter + 1) 0 l
 

 // sum with fold function
let sumList (l : 'a list) =
    List.fold (fun sum x -> sum + x) 0 l


let rec rev (l : 'a list) =
    match l with
        | [] -> []
        | x :: xs ->
             // @ means concatination
            (rev xs) @ [x] 


let palindrome (l : 'a list) = 
    l = (rev l)
    //palindrome [1;2;5;2;1]


type NestedList<'a> =
     | Element of 'a
     | Nested of List<NestedList<'a>> // allows [3;[8;7];9]


let rec flatten (l : List<NestedList<'a>>) : 'a list =
    List.fold (fun flattened x ->
                do printfn "text flatten %A \t procecced element : %A" flattened x
                match x with 
                | Element y -> flattened @ [y]
                | Nested ys -> flattened @ (flatten ys)) [] l


let rec countRepetition (element : 'a) (l : 'a list) = 
    match l with
    | [] -> 0
    | x :: xs -> 
        if x = element then
            1 + (countRepetition element xs)
        else
            0


let rec skip (amount : int) (l: 'a list) = 
    match l with 
    | [] -> 
        if amount > 0 then
           failwith "blown fuse"
        else
         []
    | x :: xs ->
        if amount > 0 then
        skip(amount - 1) xs
        else
          l


let rec compress (l : 'a list) : 'a list = []

[<EntryPoint>]
let main argv = 
try 
    let testNested = [Element 3; Nested[Element 5;Element 7]; Element 4] //[3;[5;7];4]
    printfn "%A" (palindrome [1;2;5;2;1])
    0
with
| :? Exception as e ->
    printfn "%A" e.Message
    1