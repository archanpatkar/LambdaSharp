#load "./LambdaSharp.fsx"
open System
open LambdaSharp      
        
LambdaSharp.transpileFromFile "one.ls" "one.target.fsx"
