// JAVASCRIPT MANIPULATION
/*left and right asides manipulation */

const coverLayer = document.querySelector(".cover-layer");
const hamburgerMenu = document.getElementById("menu");
const userRegistration = document.querySelector(".user");
const shop = document.querySelector(".select-market");
const hamburgerQueryMenu = document.querySelector(".media-query-menu");
const quitIconLeftAside = document.getElementById("closeLeftAside");
const quitIconRightAside = document.getElementById("closeRightAside");
const rightBar = document.getElementById("right-aside-onclick");
const leftBar = document.getElementById("left-aside-onclick");

function openLeftAside() {
  if (window.innerWidth >= 900) {
    leftBar.style.visibility = "visible";
    leftBar.style.width = "500px";
    leftBar.style.transition = "0.2s ease";
    coverLayer.style.width = "100vw";
    coverLayer.style.height = "100vh";
    coverLayer.style.display = "block";
  } else if (window.innerWidth < 900 && window.innerWidth >= 350) {
    leftBar.style.visibility = "visible";
    leftBar.style.width = "100vw";
    leftBar.style.transition = "0.2s ease";
    coverLayer.style.width = "100vw";
    coverLayer.style.height = "100vh";
    coverLayer.style.display = "block";
  } else if (window.innerWidth < 350) {
    leftBar.style.visibility = "visible";
    leftBar.style.width = "100vw";
    leftBar.style.transition = "0.2s ease";
    coverLayer.style.width = "100vw";
    coverLayer.style.height = "100vh";
    coverLayer.style.display = "block";
  }
}

function closeLeftAside() {
  leftBar.style.visibility = "collapse";
  leftBar.style.width = "0px";
  leftBar.style.transition = "0.2s ease";
  coverLayer.style.width = "0";
  coverLayer.style.height = "0";
  coverLayer.style.display = "none";
}

function openRightAside() {
  if (window.innerWidth >= 600) {
    rightBar.style.visibility = "visible";
    rightBar.style.width = "450px";
    rightBar.style.transition = "0.2s ease";
    coverLayer.style.width = "100vw";
    coverLayer.style.height = "100vh";
    coverLayer.style.display = "block";
  } else if (window.innerWidth < 600) {
    rightBar.style.visibility = "visible";
    rightBar.style.width = "100vw";
    rightBar.style.transition = "0.2s ease";
    coverLayer.style.width = "100vw";
    coverLayer.style.height = "100vh";
    coverLayer.style.display = "block";
  }
}

function closeRightAside() {
  rightBar.style.visibility = "collapse";
  rightBar.style.width = "0px";
  rightBar.style.transition = "0.2s ease";
  coverLayer.style.width = "0";
  coverLayer.style.height = "0";
  coverLayer.style.display = "none";
}

shop.addEventListener("click", openRightAside);
userRegistration.addEventListener("click", openRightAside);
quitIconRightAside.addEventListener("click", closeRightAside);
quitIconLeftAside.addEventListener("click", closeLeftAside);
hamburgerQueryMenu.addEventListener("click", openLeftAside);
hamburgerMenu.addEventListener("click", openLeftAside);
coverLayer.addEventListener("click", closeLeftAside);
coverLayer.addEventListener("click", closeRightAside);

//end asides manipulation

/*form manipulation */
const submitBtn = document.getElementById("submit");

submitBtn.addEventListener("click", (event) => {
  event.preventDefault();
  name = document.getElementById("name").value;
  surname = document.getElementById("surname").value;
  age = document.getElementById("age").value;
  gender = document.getElementById("gender").value;
  email = document.getElementById("email-address").value;
  rating = document.getElementById("page-rating").value;
  userOpinion = document.getElementById("text-area").value;

  if (name) console.log(`user Name: `, name);
  if (surname) console.log(`user Surname: `, surname);
  if (gender === "male" || gender === "female" || gender === "other") console.log(`user Gender: `, gender);
  if (age >= 1 && age <= 100) console.log(`user Age: `, age);
  if (email) console.log(`user Email: `, email);
  if (rating > 0 && rating <= 10) console.log("user Page-Rating: ", rating);
  if (userOpinion) console.log("user Opinion: ", userOpinion);
});
