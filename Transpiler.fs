open System
open System.Collections.Generic

type tokens = 
    | LAMBDA 
    | DOT 
    | VARIABLE
    | WHITESPACE 
    | PAREN 
    | NULL

let display token =
   match token with
   | (ttype , value) -> printfn "Token [ type: %A value: %A ]" ttype value

let tokenizer c =
    match c with 
    | '^' -> (LAMBDA ,c)
    | '.' -> (DOT,c)
    | ' ' -> (WHITESPACE, c)
    | '(' -> (PAREN, c)
    | ')' -> (PAREN, c)
    | _ -> (VARIABLE ,c)

let tokens string =
    let mutable tokens =  new List<tokens * char>()
    let mutable token:tokens * char = (NULL,' ')
    for c in string do 
       tokens.Add(c |> tokenizer)
    tokens

let transpile tokens =
    let mutable transpiled = ""
    for token in tokens do
        match token with
        | (WHITESPACE,' ') -> transpiled <- transpiled + " "
        | (PAREN,'(') -> transpiled <- transpiled + "("
        | (LAMBDA,'^') -> transpiled <- transpiled + "fun "
        | (VARIABLE,_) -> transpiled <- transpiled + Convert.ToString(snd(token)) + ""
        | (DOT,'.') -> transpiled <- transpiled + "->"
        | (PAREN,')') -> transpiled <- transpiled + ")"
        | _ -> printfn "Ignoring"
    transpiled

// "(^x. x) ^y.y" |> tokens |> Seq.iteri (fun index item -> printfn "%A" item)

"(^b. b(^x.^y.x)(^x.^y.y))(^x.^y.x)" |> tokens |> transpile |> Console.WriteLine

Console.WriteLine((fun b-> b(fun x->fun y->x)(fun x->fun y->y))(fun x->fun y->x))
