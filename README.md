# <img src="./lambdasharplogo.png">

### A Language inspired from [Lambda Calculus](https://en.wikipedia.org/wiki/Lambda_calculus) written in F#

### Which transpiles to F# !


## Introduction

#### L# supports Pure Functional paradigm 

#### It provides `Function Abstractions` from `Lambda Calculus`


## Example

#### `L# Code`
```
( ^b. ( b( ^x. ^y. x ) ) ( ^x. ^y. y ) ) ( ^x. ^y. x )
```
       
#### `Transpiled to F#`
```f#
( fun b-> ( b( fun x-> fun y-> x ) ) ( fun x-> fun y-> y ) ) ( fun x-> fun y-> x )
```

#### `Bundler Code`
```f#
#load "../LambdaSharp.fsx"
open LambdaSharp      
LambdaSharp.transpileFromFile "./one.lsx" "one.target.fsx"
```

## More on Lambda Calculus
#### [Introduction](https://www.inf.fu-berlin.de/lehre/WS03/alpi/lambda.pdf)
#### [Church Encoding](https://en.wikipedia.org/wiki/Church_encoding)
#### [Church Encodings Implementation](https://github.com/archanpatkar/ChurchEncodings)

## License

### MIT
#### Copyright (c) 2018 Archan Patkar
