let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y // Output: 20 10

// However, if we try to swap the values within a function with mutable variables, it won't work as expected.

let swapInFunction x y =
    let mutable temp = x
    x <- y
    y <- temp
    (x,y)

let a = 10
let b = 20
let (c,d) = swapInFunction a b
printfn "%d %d" c d // Output: 20 10
printfn "%d %d" a b // Output: 10 20

//The reason for this is that mutable variables are only mutable within their scope.  In the first example, x and y are mutable at the top level, while in the second example the mutable variables are created inside the function which makes them local variables and changes are only visible within the function. If you want to swap the values outside the function as well, you need to pass them as ref parameters. 

let swapRef x y =
    let temp = !x
    x := !y
    y := temp

let mutable a = 10
let mutable b = 20

swapRef &a &b

printfn "%d %d" a b // Output: 20 10