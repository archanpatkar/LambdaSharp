module LambdaSharp

    open System 
    open System.IO
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
        let mutable token:tokens * char <- (NULL,' ')
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

    let leval string =
        string |> tokens |> transpile

    let transpileFromFile ls target =
        let tols = File.ReadAllText(ls) |> leval;
        let stream = new FileStream(target, FileMode.Create)
        let writer = new StreamWriter(stream)
        writer.AutoFlush <- true
        writer.WriteLine(tols)
