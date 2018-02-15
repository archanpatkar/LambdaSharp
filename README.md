# L# (LambdaSharp)
### A Language for λ Lambda Calculus written in F#

### Which transpiles to F# !

## Demo

#### `LambdaSharp Code`
```
( ^b. ( b( ^x. ^y. x ) ) ( ^x. ^y. y ) ) ( ^x. ^y. x )
```

       |
       V
       
#### `Transpiled to F#`
```f#
( fun b-> ( b( fun x-> fun y-> x ) ) ( fun x-> fun y-> y ) ) ( fun x-> fun y-> x )
```
