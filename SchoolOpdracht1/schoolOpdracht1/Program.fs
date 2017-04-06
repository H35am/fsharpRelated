// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.


//Andere manier van schrijven van een lambda function
//let rec length (l : List<int>) : int =
//    if(l = []) then 
//          0
//        else
//          (length l.Tail) + 1


//Andere manier van schrijven van een lambda function
//let rec length (l : List<int>) : int =
//    match l with
//    | [] -> 0
//    | _ :: xs -> 1 + (length xs)

type Constant = 
| Integer of int
| Double of float
| String of string

let combine (c1: Constant) (c2: Constant) =
    match c1 with 
    | Integer x ->
        match c2 with 
        | Integer y -> Integer (x + y)
        | Double y -> Double (y + (float y))
        | String s -> String (s + (string x))
    | Double x ->
        match c2 with 
        | Integer y -> Integer (x + y)
        | Double y -> Double (y + (float y))
        | String s -> String (s + (string x))


let rec incList (l : List<int>) : List<int> =
    match l with
    | [] -> []
    | x :: xs -> (x + 1) :: (incList xs)


let rec mulList (l : List<int>) (f : int -> int) : List<int> =
    match l with
    | [] -> []
    | x :: xs -> (f x) :: (mulList xs f)

//Lengte van list met 'a geef je aan dat de list een generieke typ 
let rec length =
    fun  (l : List<'a>) ->
        if(l = []) then 
          0
        else
          (length l.Tail) + 1


// Tel op inhoud list
let rec add (l : List<int>) : int = 
    match l with
    | [] -> 0
    | x :: xs -> x + (add xs)

let rec map (l : List<'a>) (f: 'a -> 'b) : List<'b> =
    match l with
    |[] -> []
    |x :: xs -> (f x) :: (map xs f)

let rec fold (f : 'state -> 'a -> 'state) (acc : 'state) (l : list<'a>) : 'state = 
 match l with
    | [] -> acc 
    | x :: xs ->
        let newAcc

[<EntryPoint>]
let main argv = 
    let myTuples =(3,5,7)
    let testList = [3;-1;4;6]
    let x,y,z = myTuples
    let myConstant = "Hello world!"
    // return an integer exit code

    // do printfn "%A" (incList testList)
    //do printfn "%A" (List.map (fun x -> x + 1) testList)
    do printfn "%A" (List.fold (+) 0 testlist)
