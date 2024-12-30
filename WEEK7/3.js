//3a
let nameArr = [
  "ayo",
  "sade",
  "jide",
  "ife"
]

for (let x in nameArr){
  console.log(nameArr[x])
}

nameArr.forEach(item => {
  console.log(item)
});


//3b
let numArray = [
  1,
  2,
  3,
  4,
  5
]

let sum = 0;
numArray.forEach(item => {
  sum += item
})
console.log(sum)