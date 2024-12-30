// 1. Add two numbers
function add(a, b) {
  return a + b;
}
console.log("Add:", add(3, 7)); 

// 2. Check if a string is empty
function isEmptyString(str) {
  return str.trim().length === 0;
}
console.log("Is Empty String:", isEmptyString("   ")); 

// 3. Find the maximum value in an array
function findMax(arr) {
  return Math.max(...arr);
}
console.log("Max Value:", findMax([5, 1, 8, 2])); 

// 4. Check if an array is empty
function isEmptyArray(arr) {
  return arr.length === 0;
}
console.log("Is Empty Array:", isEmptyArray([])); 

// 5. Capitalize the first letter of a string
function capitalizeFirstLetter(str) {
  return str.toLowerCase().charAt(0).toUpperCase() + str.slice(1).toLowerCase();
}
console.log("Capitalized:", capitalizeFirstLetter("hello")); 

// 6. Merge two arrays
function mergeArrays(arr1, arr2) {
  return [...arr1, ...arr2];
}
console.log("Merged Arrays:", mergeArrays([1, 2], [3, 4])); 

// 7. Check if an element exists in an array
function elementExists(arr, element) {
  return arr.includes(element);
}
console.log("Element Exists:", elementExists([1, 2, 3], 2)); 

// 8. Convert a string to lowercase
function toLowerCase(str) {
  return str.toLowerCase();
}
console.log("Lowercase:", toLowerCase("HELLO")); 

// 9. Convert a string to uppercase
function toUpperCase(str) {
  return str.toUpperCase();
}
console.log("Uppercase:", toUpperCase("hello")); 

// 10. Generate a random number between two values
function randomBetween(min, max) {
  return Math.random() * (max - min) + min;
}
console.log("Random Number:", randomBetween(1, 10)); 

// 11. Trim whitespace from a string
function trimString(str) {
  return str.trim();
}
console.log("Trimmed String:", trimString("   hello   ")); 

// 12. Get the current timestamp
function getCurrentTimestamp() {
  return Date.now();
}
console.log("Timestamp:", getCurrentTimestamp()); 

// 13. Convert a string to a number
function toNumber(str) {
  return parseFloat(str);
}
console.log("Converted Number:", toNumber("42.5")); 

// 14. Sort an array in ascending order
function sortAscending(arr) {
  return arr.sort();
}
console.log("Sorted Array:", sortAscending([5, 3, 8, 1])); 

// 15. Get the current date in 'YYYY-MM-DD' format
function getFormattedDate() {
  const date = new Date();
  return date.toISOString().split('T')[0];
}
console.log("Formatted Date:", getFormattedDate()); 

// 16. Round a number to two decimal places
function roundToTwoDecimals(num) {
  return Math.round(num * 100) / 100;
}
console.log("Rounded Number:", roundToTwoDecimals(5.6789)); 

// 17. Check if a number is odd
function isOdd(num) {
  return num % 2 !== 0;
}
console.log("Is Odd:", isOdd(7)); 

// 18. Remove an element from an array
function removeElement(arr, element) {
  return arr.filter(item => item !== element);
}
console.log("Array Without Element:", removeElement([1, 2, 3], 2)); 

// 19. Find the index of an element in an array
function findIndex(arr, element) {
  return arr.indexOf(element);
}
console.log("Index:", findIndex([10, 20, 30], 20)); 

// 20. Remove duplicates from an array
function removeDuplicates(arr) {
  return [...new Set(arr)];
}
console.log("Without Duplicates:", removeDuplicates([1, 2, 2, 3, 4, 4, 5]));
