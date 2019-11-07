'use strict';

let userName = document.getElementById("form").username;
let passWord = document.getElementById("form").password;
let submitButton = document.getElementById("form").submit;

let error = document.getElementById("ErrorMessage");

submitButton.onclick = function() {
    
    ValidateLogin();
    
}

function ValidateLogin() {
    if(userName == "ansimi" && passWord == "ansimi") {
        document.location = "LoggedIn.html";
    }
    else if(userName == "" && passWord == "") {
        error.innerHTML = "Enter all fields!";
    }
    else {
        error.innerHTML = "Wrong Credentials";
    }
}