// 1. check the day of the week
function getDayMessage(day) {
  switch (day) {
      case "Monday":
          console.log("Start of the work week!");
          break;
      case "Friday":
          console.log("Almost the weekend!");
          break;
      case "Saturday":
      case "Sunday":
          console.log("It's the weekend!");
          break;
      default:
          console.log("Just another weekday.");
  }
}
getDayMessage("Saturday"); // Output: "It's the weekend!"


// 2. check user role
function getUserAccess(role) {
  switch (role) {
      case "admin":
          console.log("Full access granted.");
          break;
      case "editor":
          console.log("Access granted to edit content.");
          break;
      case "viewer":
          console.log("Access granted to view content.");
          break;
      default:
          console.log("No access granted.");
  }
}
getUserAccess("editor"); // Output: "Access granted to edit content."



// 3. grade evaluation
function evaluateGrade(score) {
  switch (true) {
      case score >= 90:
          console.log("Grade: A");
          break;
      case score >= 80:
          console.log("Grade: B");
          break;
      case score >= 70:
          console.log("Grade: C");
          break;
      case score >= 60:
          console.log("Grade: D");
          break;
      default:
          console.log("Grade: F");
  }
}
evaluateGrade(85); // Output: "Grade: B"


// 4. traffic light system
function trafficLightAction(light) {
  switch (light) {
      case "red":
          console.log("Stop");
          break;
      case "yellow":
          console.log("Get ready to move");
          break;
      case "green":
          console.log("Go");
          break;
      default:
          console.log("Invalid light color.");
  }
}
trafficLightAction("green"); // Output: "Go"



// 5. select favorite fruit
function selectFruit(fruit) {
  switch (fruit) {
      case "apple":
          console.log("You selected apple!");
          break;
      case "banana":
          console.log("You selected banana!");
          break;
      case "orange":
          console.log("You selected orange!");
          break;
      default:
          console.log("Unknown fruit selected.");
  }
}
selectFruit("banana"); // Output: "You selected banana!"
