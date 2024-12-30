/*
2a.
*/
let fruits = [
  "apple",
  "orange",
  "water melon",
  "golden melon",
  "garden egg",
  "guava"
]

console.log(fruits[0], fruits[2], fruits[-1])

//2b
const num = [
  1,
  2,
  3,
  4,
  5,
  6,
  7,
  8,
  9,
  10
]
console.log(num.reverse())


//2c
num[1] = 20
console.log(num)
num.unshift(31, 32)
console.log(num)
num.pop()
console.log(num)