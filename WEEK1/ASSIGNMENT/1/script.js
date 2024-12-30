// Function to toggle the password visibility
document.getElementById("showPassword").addEventListener("change", function() {
    var passwordField = document.getElementById("passwordField");
    // Toggle the type attribute between 'password' and 'text'
    if (this.checked) {
        passwordField.type = "text"; // Show password
    } else {
        passwordField.type = "password"; // Hide password
    }
});
