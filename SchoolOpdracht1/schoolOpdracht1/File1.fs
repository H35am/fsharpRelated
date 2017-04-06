type Program = 
{ 
 Statements : List<Statements>
 Variables  : Map<String, Literal>
}

with
static member Create(statments : List<Statment>) =
{
Statements = statemnets
Variables = Map.empty
}



override this.ToString() =
statement |> List.fold(fun s stmt -> s + (sting stmt) + "\n") "")
"\n\n---------VARIABLES--------\n\n"
(this.Variables |> Map.fold (fun s k v ->)


type Statement = 
| Declaration of string * Expression // x = 5 + y * 4
| Block of List<Statement>
| If of Expression * Statement
with
override this.ToString() = this.CreateString 0
member private this.CreateString indent =
    let rec generateSpaces indent =
    match indent with
    | 0 -> ""
    | n -> " " + (generateSpaces (indent -1))
    let

                           