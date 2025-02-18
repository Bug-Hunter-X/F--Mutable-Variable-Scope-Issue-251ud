let swapRef x y =
    let temp = !x
    x := !y
    y := temp

let mutable a = 10
let mutable b = 20

swapRef &a &b

printfn "%d %d" a b // Output: 20 10

//This version uses ref parameters to correctly swap the values, making the changes visible outside the function.