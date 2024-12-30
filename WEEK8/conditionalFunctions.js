// 1. check age for different stages
function checkAge(age) {
  if (age < 13) {
      console.log("You're a child.");
  } else if (age >= 13 && age < 20) {
      console.log("You're a teenager.");
  } else if (age >= 20 && age < 65) {
      console.log("You're an adult.");
  } else {
      console.log("You're a senior citizen.");
  }
}
checkAge(25); // Output: "You're an adult."


// 2. check for eligibility to vote and drive
function checkEligibility(age, citizenship) {
  if (age >= 18 && citizenship === "yes") {
      console.log("You can vote and drive.");
  } else if (age >= 16 && age < 18) {
      console.log("You can drive but can't vote.");
  } else {
      console.log("You're not eligible to vote or drive.");
  }
}
checkEligibility(17, "yes"); // Output: "You can drive but can't vote."



// 3. check user role and access level
function checkAccess(role, isLoggedIn) {
  if (role === "admin" && isLoggedIn) {
      console.log("Access granted with full permissions.");
  } else if (role === "user" && isLoggedIn) {
      console.log("Access granted with limited permissions.");
  } else {
      console.log("Access denied.");
  }
}
checkAccess("admin", true); // Output: "Access granted with full permissions."



// 4. number age classification
function classifyNumber(num) {
  if (num > 0 && num <= 10) {
      console.log("Small number");
  } else if (num > 10 && num <= 100) {
      console.log("Medium number");
  } else if (num > 100) {
      console.log("Large number");
  } else {
      console.log("Non-positive number");
  }
}
classifyNumber(50); // Output: "Medium number"



// 5. chech weather conditions
function checkWeather(temp, isRaining) {
  if (temp > 30 && !isRaining) {
      console.log("It's hot and sunny outside.");
  } else if (temp <= 30 && temp > 20 && isRaining) {
      console.log("It's warm but rainy.");
  } else {
      console.log("It's either cold or rainy.");
  }
}
checkWeather(25, true); // Output: "It's warm but rainy."


// 6. evaluate student grade
function evaluateGrade(score) {
  if (score >= 90) {
      console.log("Grade: A");
  } else if (score >= 80 && score < 90) {
      console.log("Grade: B");
  } else if (score >= 70 && score < 80) {
      console.log("Grade: C");
  } else if (score >= 60 && score < 70) {
      console.log("Grade: D");
  } else {
      console.log("Grade: F");
  }
}
evaluateGrade(85); // Output: "Grade: B"


// 7. check password strength
function checkPasswordStrength(password) {
  if (password.length >= 8 && /\d/.test(password) && /[A-Z]/.test(password)) {
      console.log("Strong password");
  } else if (password.length >= 6 && /\d/.test(password)) {
      console.log("Moderate password");
  } else {
      console.log("Weak password");
  }
}
checkPasswordStrength("Pass1234"); // Output: "Strong password"
