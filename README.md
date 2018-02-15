# L# (LambdaSharp)
### A Language for λ Lambda Calculus written in F#

### Which transpiles to F# !

## Demo

> LambdaSharp code in .lsx file
### one.lsx
```
( ^b. ( b( ^x. ^y. x ) ) ( ^x. ^y. y ) ) ( ^x. ^y. x )
```

> Transpiled to F# from L#(LambdaSharp)
### one.target.fsx
```f#
( fun b-> ( b( fun x-> fun y-> x ) ) ( fun x-> fun y-> y ) ) ( fun x-> fun y-> x )
```

> Bundler code for F# to L# traspilation
### Bundler.fsx
```f#
#load "../LambdaSharp.fsx"
open System
open LambdaSharp      
        
LambdaSharp.transpileFromFile "./one.ls" "one.target.fsx"
```
