// Function to toggle the password visibility for the password field
document.getElementById("showPassword").addEventListener("change", function() {
    var passwordField = document.getElementById("passwordField");

    if (this.checked) {
        passwordField.type = "text"; // Show password
    } else {
        passwordField.type = "password"; // Hide password
    }
});

// Function to toggle the password visibility for the confirm password field
document.getElementById("showConfirmPassword").addEventListener("change", function() {
    var confirmPasswordField = document.getElementById("confirmPasswordField"); 

    if (this.checked) {
        confirmPasswordField.type = "text"; // Show confirm password
    } else {
        confirmPasswordField.type = "password"; // Hide confirm password
    }
});

// Updated to use 'input' event for immediate feedback
document.getElementById("confirmPasswordField").addEventListener("input", function() {
    var passwordField = document.getElementById("passwordField");
    var incorrectPassword = document.getElementById("incorrectPassword");

    if (this.value !== passwordField.value) {
        // If passwords don't match, set the border color to red for both fields
        passwordField.style.borderColor = "red";
        this.style.borderColor = "red";
        incorrectPassword.textContent = "incorrect password"

    } else {
        // If they match, reset the border colors for both fields
        passwordField.style.borderColor = "";
        this.style.borderColor = "";
        incorrectPassword.textContent = ""
    }
});
