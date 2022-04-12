const hamburgerMenu = document.querySelectorAll(".hamburger-menu");
const userMenu = document.getElementById("user");
const closeButton = document.querySelectorAll(".close-btn");
const layer = document.getElementById("layer");
const shareBtn = document.querySelector(".share-btn");

function openSidenav(sidenavId) {
  let sidenav = document.getElementById(sidenavId);

  if (window.innerWidth < 780) {
    sidenav.style.width = "100%";
  } else {
    sidenav.style.width = "450px";
    layer.style.display = "block";
  }

  sidenav.style.visibility = "visible";
}

function closeSidenav(event) {
  let sidenav = document.getElementById(event.currentTarget.parentElement.id);
  sidenav.style.width = "0px";
  sidenav.style.visibility = "hidden";
  layer.style.display = "none";
}

hamburgerMenu.forEach((item) =>
  item.addEventListener("click", function () {
    openSidenav("left-sn");
  })
);

userMenu.addEventListener("click", function () {
  openSidenav("right-sn");
});

closeButton.forEach((item) =>
  item.addEventListener("click", function () {
    closeSidenav(event);
  })
);

shareBtn.addEventListener("click", function () {
  openSidenav("share-sn");
});

window.onscroll = (event) => {
  if (window.pageYOffset / 100 > 35) {
    shareBtn.style.visibility = "visible";
  } else {
    shareBtn.style.visibility = "hidden";
  }
};

layer.addEventListener("click", () => {
  let allAside = document.querySelectorAll("aside");
  allAside.forEach((item) => {
    item.style.width = "0px";
    item.style.visibility = "hidden";
    layer.style.display = "none";
  });
});

//***************
//SCRIPT FOR FORM
//***************

const form = document.querySelector("form");
const sendBtn = document.getElementById("sendBtn");
let allFields = document.querySelectorAll(".form-input");
let phone = document.getElementById("phone");
let cap = document.getElementById("cap");
let checkbox = document.getElementById("terms");
let userData = {};

function getAndPrint() {
  userData = {
    fname: form.fname.value,
    lname: form.lname.value,
    city: form.city.value,
    province: form.province.value,
    cap: form.cap.value,
    email: form.email.value,
    phone: form.phone.value,
    text: form.info.value,
  };

  for (const [key, value] of Object.entries(userData)) {
    console.log(`${key}: ${value}`);
  }
  window.alert("Dati inviati correttamente!");
}

function checkInput(event) {
  let currentField = event.target;
  let span = currentField.nextElementSibling;
  let keyPressed = event.charCode;

  if (keyPressed < 48 || keyPressed > 57) {
    event.preventDefault();
    currentField.classList.add("errorInput");
    span.classList.add("errorLabel");
    let errMsg = document.createTextNode(" solo numeri!");
    span.appendChild(errMsg);

    setTimeout(() => {
      currentField.classList.remove("errorInput");
      span.classList.remove("errorLabel");
      span.removeChild(errMsg);
    }, 1500);
  }
}

function moveUpPlaceholder(event) {
  let currentField = event.target;
  let span = currentField.nextElementSibling;

  span.classList.add("movedUp");
}

function moveDownPlaceholder(event) {
  let currentField = event.target;
  let span = currentField.nextElementSibling;

  if (!currentField.value) {
    span.classList.remove("movedUp");
  }
}

allFields.forEach((field) => {
  field.addEventListener("focusin", moveUpPlaceholder);
  field.addEventListener("focusout", moveDownPlaceholder);
});

phone.addEventListener("keypress", checkInput, false);
cap.addEventListener("keypress", checkInput);
form.addEventListener("submit", function (e) {
  e.preventDefault();
});
sendBtn.addEventListener("click", getAndPrint);
