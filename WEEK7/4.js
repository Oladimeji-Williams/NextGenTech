//4a
let ages = [
  2,
  8,
  14,
  20,
  26,
  32,
  38
]

console.log(ages.filter(age => age>18))

//4b
let names = [
  "sade",
  "wale",
  "titi",
  "ayo",
  "dipo"
]

names.sort((a, b) => {
  if(a>b){
    return -1
  }
  if(a<b){
    return 1
  }
  return 0
})

console.log(names)