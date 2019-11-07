'use strict';

let textElement = document.getElementById("textElement");
textElement.innerHTML = "Howdy?";

window.onload = function () {
    textElement.innerHTML = "Cowpoke!";
}

window.addEventListener('load', function () {
    alert("Howdy Cowpoke?");
});

window.addEventListener('DOMContentLoaded', function () {
    alert("Howdy Cowpoke?!?!");
});

let list = document.getElementById('list');
let counter = 0;

textElement.onclick = function() {
    textElement.innerHTML += "!";
    let item = document.createElement('li');
    item.innerHTML = "TEST " + counter++; 
    list.appendChild(item);
}