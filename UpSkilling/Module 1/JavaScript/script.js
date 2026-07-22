// ================================
// Exercise 1 - JavaScript Basics
// ================================

let portalName = "Local Community Event Portal";
const currentYear = 2026;

console.log(portalName);
console.log(currentYear);

// ===========================================
// Exercise 2 - Variables, Operators & Conditions
// ===========================================

let userName = "Visitor";
let isRegistered = false;

function welcomeUser() {

    if (isRegistered) {
        alert("Welcome back, " + userName + "!");
    }
    else {
        alert("Welcome to the Local Community Event Portal!");
    }

}
// =====================================
// Exercise 3 - Conditionals, Loops & Error Handling
// =====================================

const events = [

    {
        name: "Marathon",
        category: "Sports",
        date: "2026-08-15",
        seats: 50
    },

    {
        name: "Food Festival",
        category: "Food",
        date: "2025-05-10",
        seats: 100
    },

    {
        name: "Music Concert",
        category: "Music",
        date: "2026-09-10",
        seats: 0
    },

    {
        name: "Tree Plantation",
        category: "Social",
        date: "2026-10-20",
        seats: 40
    }

];
console.log("Available Events");

events.forEach(function(event){

    let today = new Date();

    let eventDate = new Date(event.date);

    if(eventDate >= today && event.seats > 0){

        console.log(event.name + " (" + event.category + ")");

    }

});
// =====================================
// Exercise 4 - Functions, Scope, Closures & Higher-Order Functions
// =====================================

// Add a new event
function addEvent(name, category, date, seats){

    events.push({
        name: name,
        category: category,
        date: date,
        seats: seats
    });

    console.log(name + " added successfully.");

}

// Register a user
function registerUser(eventName){

    let event = events.find(function(e){

        return e.name === eventName;

    });

    if(event && event.seats > 0){

        event.seats--;

        console.log("Successfully registered for " + eventName);

    }

    else{

        console.log("Registration failed for " + eventName);

    }

}

// Filter events by category
function filterEventsByCategory(category){

    return events.filter(function(event){

        return event.category === category;

    });

}
// Closure Example

function registrationCounter(){

    let totalRegistrations = 0;

    return function(){

        totalRegistrations++;

        console.log("Total Registrations: " + totalRegistrations);

    };

}

const countRegistration = registrationCounter();
function searchEvents(callback){

    callback(events);

}
function displayMusicEvents(eventList){

    let musicEvents = eventList.filter(function(event){

        return event.category === "Music";

    });

    console.log(musicEvents);

}
addEvent("Coding Workshop","Education","2026-12-01",60);

registerUser("Marathon");

console.log(filterEventsByCategory("Sports"));

countRegistration();
countRegistration();

searchEvents(displayMusicEvents);

// =====================================
// Exercise 5 - Objects & Prototypes
// =====================================

// Constructor Function
function Event(name, category, date, seats) {

    this.name = name;
    this.category = category;
    this.date = date;
    this.seats = seats;

}

// Prototype Method
Event.prototype.checkAvailability = function () {

    if (this.seats > 0) {

        return "Seats Available";

    }

    return "Registration Closed";

};
let workshop = new Event(

    "Web Development Workshop",
    "Education",
    "2026-11-15",
    80

);

console.log(workshop);
console.log(workshop.checkAvailability());
console.log("Workshop Details");

Object.entries(workshop).forEach(function(entry){

    console.log(entry[0] + " : " + entry[1]);

});
// =====================================
// Exercise 6 - Arrays & Array Methods
// =====================================
events.push({

    name: "Art Exhibition",
    category: "Arts",
    date: "2026-12-20",
    seats: 70

});

console.log("New Event Added Successfully");
let availableEvents = events.filter(function(event){

    return event.seats > 0;

});

console.log("Available Events");

console.log(availableEvents);
let eventNames = events.map(function(event){

    return event.name;

});

console.log("Event Names");

console.log(eventNames);
let eventDetails = events.map(function(event){

    return event.name + " - " + event.category;

});

console.log(eventDetails);
// =====================================
// Exercise 7 - DOM Manipulation
// =====================================

function displayEvents() {

    let container = document.querySelector("#eventContainer");

    container.innerHTML = "";

    events.forEach(function(event) {

        let card = document.createElement("div");

        card.style.border = "1px solid black";
        card.style.padding = "10px";
        card.style.margin = "10px";
        card.style.backgroundColor = "#f5f5f5";

        card.innerHTML =
            "<h3>" + event.name + "</h3>" +
            "<p>Category: " + event.category + "</p>" +
            "<p>Date: " + event.date + "</p>" +
            "<p>Seats: " + event.seats + "</p>";

        container.appendChild(card);

    });

}
// =====================================
// Exercise 8 - Event Handling
// =====================================

function searchEvent() {

    let keyword = document
        .getElementById("searchBox")
        .value
        .toLowerCase();

    let result = document.getElementById("searchResult");

    let matchedEvents = events.filter(function(event) {

        return event.name.toLowerCase().includes(keyword);

    });

    if (matchedEvents.length > 0) {

        result.innerHTML =
            "Found: " +
            matchedEvents.map(function(event) {
                return event.name;
            }).join(", ");

    }

    else {

        result.innerHTML = "No matching event found.";

    }

}
// =====================================
// Exercise 9 - Async JavaScript
// =====================================

function loadEvents() {

    document.getElementById("loading").innerHTML = "Loading events...";

    fetch("https://jsonplaceholder.typicode.com/posts?_limit=5")

    .then(function(response) {

        return response.json();

    })

    .then(function(data) {

        let list = document.getElementById("apiEvents");

        list.innerHTML = "";

        data.forEach(function(post) {

            let item = document.createElement("li");

            item.innerHTML = post.title;

            list.appendChild(item);

        });

        document.getElementById("loading").innerHTML = "";

    })

    .catch(function(error) {

        document.getElementById("loading").innerHTML =
        "Error loading events.";

        console.log(error);

    });

}
async function loadEventsAsync() {

    try {

        document.getElementById("loading").innerHTML = "Loading events...";

        let response = await fetch("https://jsonplaceholder.typicode.com/posts?_limit=5");

        let data = await response.json();

        let list = document.getElementById("apiEvents");

        list.innerHTML = "";

        data.forEach(function(post) {

            let item = document.createElement("li");

            item.innerHTML = post.title;

            list.appendChild(item);

        });

        document.getElementById("loading").innerHTML = "";

    }

    catch(error) {

        document.getElementById("loading").innerHTML =
        "Error loading events.";

        console.log(error);

    }

}
// =====================================
// Exercise 10 - ES6 Features
// =====================================
// Destructuring an Event Object

let firstEvent = events[0];

let { name, category, date, seats } = firstEvent;

console.log("First Event Details");

console.log(name);
console.log(category);
console.log(date);
console.log(seats);
// Spread Operator

let copiedEvents = [...events];

console.log("Copied Events");

console.log(copiedEvents);
// Default Parameters

function displayEvent(eventName = "Community Meetup"){

    console.log("Event Name: " + eventName);

}

displayEvent();

displayEvent("Hackathon");
let organizer = "Community Club";

console.log(`Organizer: ${organizer}`);
// =====================================
// Exercise 11 - Forms & Validation
// =====================================

function validateForm(event){

    event.preventDefault();

    let form = document.getElementById("registrationForm");

    let name = form.elements["name"].value.trim();

    let email = form.elements["email"].value.trim();

    let phone = form.elements["phone"].value.trim();

    let selectedEvent = form.elements["event"].value;

    let error = "";

    if(name === ""){

        error += "Name is required.<br>";

    }

    if(email === ""){

        error += "Email is required.<br>";

    }

    if(phone.length !== 10){

        error += "Phone number must contain exactly 10 digits.<br>";

    }

    if(selectedEvent === ""){

        error += "Please select an event.<br>";

    }

    if(error !== ""){

        document.getElementById("formError").innerHTML = error;

        return;

    }

document.getElementById("formError").innerHTML = "";

let userData = {

    name: name,
    email: email,
    phone: phone,
    event: selectedEvent

};

submitRegistration(userData);

}
// =====================================
// Exercise 12 - AJAX POST Request
// =====================================

function submitRegistration(userData){

    fetch("https://jsonplaceholder.typicode.com/posts", {

        method: "POST",

        headers: {

            "Content-Type": "application/json"

        },

        body: JSON.stringify(userData)

    })

    .then(function(response){

        return response.json();

    })

    .then(function(data){

        document.getElementById("msg").innerHTML =
        "Registration Successful!";

        alert("Registration Submitted Successfully!");

        console.log(data);

    })

    .catch(function(error){

        document.getElementById("msg").innerHTML =
        "Registration Failed.";

        console.log(error);

    });

}
// =====================================
// Exercise 14 - jQuery
// =====================================

$(document).ready(function () {

    $("#toggleNews").click(function () {

        $(".newsArticle").fadeToggle(1000);

    });

});
// Arithmetic Operators

let totalSeats = 100;
let bookedSeats = 45;
let availableSeats = totalSeats - bookedSeats;

console.log("Available Seats: " + availableSeats);

if (availableSeats > 0) {
    console.log("Registrations Open");
}
else {
    console.log("Registrations Closed");
}

// Comparison Operators

let age = 20;

if (age >= 18) {
    console.log("Eligible to Register");
}
else {
    console.log("Not Eligible");
}

// Logical Operators

let hasID = true;
let hasTicket = true;

if (hasID && hasTicket) {
    console.log("Entry Allowed");
}
else {
    console.log("Entry Denied");
}

// ================================
// Existing Project Functions
// ================================
// =====================================
// Exercise 3 - Functions
// =====================================

function calculateTotalFee(fee, members){

    return fee * members;

}

let totalFee = calculateTotalFee(300, 2);

console.log("Total Registration Fee: ₹" + totalFee);

function greetParticipant(name){

    return "Welcome, " + name + "!";

}

console.log(greetParticipant("Zeba"));

function checkEligibility(age){

    if(age >= 18){

        return "Eligible";

    }

    else{

        return "Not Eligible";

    }

}

console.log(checkEligibility(20));

function calculateDiscount(amount){

    if(amount >= 1000){

        return amount * 0.20;

    }

    else{

        return amount * 0.10;

    }

}

console.log("Discount: ₹" + calculateDiscount(1500));
// =====================================
// Exercise 4 - DOM Manipulation
// =====================================

function changeWelcomeMessage(){

    document.getElementById("welcomeMessage").innerHTML =
    "Welcome to the Local Community Event Portal!";

}
function changeHeadingColor(){

    document.getElementById("welcomeMessage").style.color = "blue";

}
function changeBackground(){

    document.body.style.backgroundColor = "#f0fff0";

}
function hideMessage(){

    document.getElementById("welcomeMessage").style.display = "none";

}

function showMessage(){

    document.getElementById("welcomeMessage").style.display = "block";

}

function validatePhone(input){

    if(!/^\d{10}$/.test(input.value)){
        alert("Phone number must contain exactly 10 digits");
    }

}

function showFee(){

    let event = document.getElementById("event");
    let fee = document.getElementById("fee");

    switch(event.value){

        case "Marathon":
            fee.innerHTML = "Registration Fee : ₹300";
            break;

        case "Food Festival":
            fee.innerHTML = "Registration Fee : ₹150";
            break;

        case "Music Concert":
            fee.innerHTML = "Registration Fee : ₹500";
            break;

        case "Tree Plantation":
            fee.innerHTML = "Registration Fee : Free";
            break;

        case "Blood Donation":
            fee.innerHTML = "Registration Fee : Free";
            break;

        case "Cultural Dance":
            fee.innerHTML = "Registration Fee : ₹250";
            break;

        default:
            fee.innerHTML = "";

    }

}

function saveEvent(){

    let selectedEvent = document.getElementById("event").value;

    localStorage.setItem("selectedEvent", selectedEvent);

}

function loadEvent(){

    let savedEvent = localStorage.getItem("selectedEvent");

    if(savedEvent){

        document.getElementById("event").value = savedEvent;

        showFee();

    }

}

function clearPreferences(){

    localStorage.removeItem("selectedEvent");

    document.getElementById("event").value = "";

    document.getElementById("fee").innerHTML = "";

    alert("Preferences Cleared");

}

function submitMessage(){

    try{

        let selectedEvent = document.getElementById("event").value;

        if(selectedEvent === ""){

            throw new Error("Please select an event.");

        }

        document.getElementById("formError").innerHTML = "";

let userData = {

    name: name,
    email: email,
    phone: phone,
    event: selectedEvent

};

submitRegistration(userData);

    }

    catch(error){

        alert(error.message);

    }

}
function enlargeImage(img){

    if(img.style.width == "300px"){

        img.style.width = "200px";
        img.style.height = "150px";

    }

    else{

        img.style.width = "300px";
        img.style.height = "220px";

    }

}

function countCharacters(){

    let text = document.getElementById("feedback").value;

    document.getElementById("count").innerHTML =
    "Characters : " + text.length;

}

function videoReady(){

    document.getElementById("videoMessage").innerHTML =
    "✅ Video ready to play";

}

window.onbeforeunload = function(){

    return "Are you sure you want to leave? Your form may not be saved.";

};

function findLocation(){

    if(navigator.geolocation){

        navigator.geolocation.getCurrentPosition(showPosition, showError);

    }

    else{

        document.getElementById("location").innerHTML =
        "Geolocation is not supported by this browser.";

    }

}

function showPosition(position){

    document.getElementById("location").innerHTML =
    "Latitude : " + position.coords.latitude +
    "<br>Longitude : " + position.coords.longitude;

}

function showError(error){

    switch(error.code){

        case error.PERMISSION_DENIED:

            document.getElementById("location").innerHTML =
            "Location access denied.";

            break;

        case error.POSITION_UNAVAILABLE:

            document.getElementById("location").innerHTML =
            "Location information unavailable.";

            break;

        case error.TIMEOUT:

            document.getElementById("location").innerHTML =
            "Request timed out.";

            break;

        default:

            document.getElementById("location").innerHTML =
            "Unknown error occurred.";

    }

}