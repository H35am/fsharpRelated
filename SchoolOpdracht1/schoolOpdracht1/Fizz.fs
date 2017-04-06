module Fizz

let fizzbuzz (n : int) (m : int) =
    if (n % 4 = 0) && (m % 4 = 0) then
        "Fizz buzz"
    elif n % 4 = 0 then
        "Fizz"
    elif m % 4 = 0 then
        "Buzz"
    else 
    ""

let rec zip (list1 : 'a list) (list2 : 'b list) : (('a * 'b) list) =
    match list1,list2 with
    | [],[] -> []
    | _,[]
    | [] , _ -> failwith "Failed"
    | x :: xs,y :: ys -> (x,y) :: (zip xs ys)
        
           // a list of pair     // a pair of lists 
let unzip (l: ('a * 'b) List) : (List<'a>) * (List<'b>) =
    let inv1, inv2 =
       l |>
       List.fold (fun (left,right) (x,y) -> x :: left , y :: right) ([],[])
    List.rev inv1 , List.rev inv2


let randomList() =
    let r = System.Random()
    let maxLength = r.Next(1000)
    [for x in [1.. maxLength] do
              yield r.Next(100),r.Next(100)]



