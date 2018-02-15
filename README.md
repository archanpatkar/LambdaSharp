# L# (λSharp/LambdaSharp)
### A Language inspired from λ Lambda Calculus written in F#

### Which transpiles to F# !


## Introduction

### λSharp provides Pure Functional Programming paradigm 
### It provides `Function Abstractions` from `λ Lambda Calculus` which is `Universal Model Of Computation`
### It is a `Turing Complete Language`


## Demo

#### `LambdaSharp Code`
```
( ^b. ( b( ^x. ^y. x ) ) ( ^x. ^y. y ) ) ( ^x. ^y. x )
```
       
#### `Transpiled to F#`
```f#
( fun b-> ( b( fun x-> fun y-> x ) ) ( fun x-> fun y-> y ) ) ( fun x-> fun y-> x )
```
