// 1. handling division by zero
function divideNumbers(a, b) {
  try {
      if (b === 0) {
          throw new Error("Cannot divide by zero");
      }
      console.log(`Result: ${a / b}`);
  } catch (error) {
      console.error(`Error: ${error.message}`);
  }
}

divideNumbers(10, 2); // Result: 5
divideNumbers(10, 0); // Error: Cannot divide by zero


// 2. parsing JSON
const jsonString = '{"name": "John", "age": 30}';
const invalidJsonString = '{"name": "John", "age": 30,}';

function parseJSON(json) {
    try {
        const data = JSON.parse(json);
        console.log("Parsed data:", data);
    } catch (error) {
        console.error("Error parsing JSON:", error.message);
    }
}

parseJSON(jsonString);        // Parsed data: { name: 'John', age: 30 }
parseJSON(invalidJsonString); // Error parsing JSON: Unexpected token }


// 3. accessing undefined variables
try {
  console.log(nonExistentVariable); // This will throw an error
} catch (error) {
  console.error("Caught an error:", error.message);
}
// Output: Caught an error: nonExistentVariable is not defined


// 4. using custom error messages
function validateAge(age) {
  try {
      if (age < 18) {
          throw new Error("You must be at least 18 years old");
      }
      console.log("Access granted");
  } catch (error) {
      console.error("Validation Error:", error.message);
  }
}

validateAge(20); // Access granted
validateAge(15); // Validation Error: You must be at least 18 years old
