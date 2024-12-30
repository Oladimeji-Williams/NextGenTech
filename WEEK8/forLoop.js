// 1. iterating through an array
const fruits = ["apple", "banana", "orange", "grape"];

for (let i = 0; i < fruits.length; i++) {
    console.log(`Fruit: ${fruits[i]}`);
}
// Output:
// Fruit: apple
// Fruit: banana
// Fruit: orange
// Fruit: grape

// 2. sum of numbers
let sum = 0;

for (let i = 1; i <= 10; i++) {
    sum += i;
}

console.log(`Sum of numbers from 1 to 10 is: ${sum}`);
// Output: Sum of numbers from 1 to 10 is: 55


// 3. generating multipilcation table 
const number = 5;

for (let i = 1; i <= 10; i++) {
    console.log(`${number} x ${i} = ${number * i}`);
}
// Output:
// 5 x 1 = 5
// 5 x 2 = 10
// ...
// 5 x 10 = 50


// 4. looping through an object's keys and values
const person = { name: "John", age: 30, city: "New York" };

for (const key in person) {
    console.log(`${key}: ${person[key]}`);
}
// Output:
// name: John
// age: 30
// city: New York


// 5. iterating backwards
for (let i = 10; i > 0; i--) {
  console.log(`Countdown: ${i}`);
}
// Output:
// Countdown: 10
// Countdown: 9
// ...
// Countdown: 1
