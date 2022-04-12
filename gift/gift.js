const btnMenu = document.getElementById("open-prod-full");
const overlay = document.getElementById("overlay");
const body = document.querySelector("body");

//OPEN AND CLOSE ASIDE PRODUCT (BURGER-BUTTON)
const btnMenuResp = document.querySelector(".btn-menu-resp");
const btnMenuClose = document.querySelector(".close-window-product");
const asideMenu = document.querySelector(".aside-product");

function openAsideMenu() {
  asideMenu.style.display = "block";
  overlay.style.visibility = "visible";
  body.style.overflow = "hidden";
}

btnMenu.addEventListener("click", openAsideMenu);
btnMenuResp.addEventListener("click", openAsideMenu);

function closeAsideMenu() {
  asideMenu.style.display = "none";
  overlay.style.visibility = "collapse";
  body.style.overflow = "visible";
}
overlay.addEventListener("click", closeAsideMenu);
btnMenuClose.addEventListener("click", closeAsideMenu);

//OPEN AND CLOSE ASIDE USER
const btnUser = document.querySelector(".open-user");
const btnUserClose = document.querySelector(".close-window-user");
const asideUser = document.querySelector(".aside-user");

function openAsideUser() {
  asideUser.style.display = "block";
  overlay.style.visibility = "visible";
  body.style.overflow = "hidden";
}

btnUser.addEventListener("click", openAsideUser);

function closeAsideUser() {
  asideUser.style.display = "none";
  overlay.style.visibility = "collapse";
  body.style.overflow = "visible";
}

btnUserClose.addEventListener("click", closeAsideUser);
overlay.addEventListener("click", closeAsideUser);

//OPEN AND CLOSE ASIDE SHARE
const asideShare = document.querySelector(".aside-condividi");
const btnShareCLose = document.querySelector(".close-window-cond");
const btnShareOpen = document.getElementById("btn-share");
const btnShareOpenResp = document.getElementById("btn-share-resp");

function openAsideShare() {
  asideShare.style.display = "block";
  overlay.style.visibility = "visible";
  body.style.overflow = "hidden";
}
btnShareOpenResp.addEventListener("click", openAsideShare);
btnShareOpen.addEventListener("click", openAsideShare);

function closeAsideShare() {
  asideShare.style.display = "none";
  overlay.style.visibility = "collapse";
  body.style.overflow = "visible";
}

btnShareCLose.addEventListener("click", closeAsideShare);
overlay.addEventListener("click", closeAsideShare);

//ON SCROLL DISPLAY SHARE BUTTON AND CHANGE COLORS
const btnGoUp = document.getElementById("btn-up");
const textBlack = document.querySelectorAll(".text-change-color");
const svgBlack = document.querySelectorAll(".svg-change-color");

function scrollFunction() {
  if (document.documentElement.scrollTop > 3400 && innerWidth > 1200 && outerWidth > 1200) {
    btnShareOpen.style.display = "flex";
    btnGoUp.style.backgroundColor = "#111";
    btnShareOpen.style.backgroundColor = "#111";
    svgBlack[0].style.fill = "white";
    svgBlack[1].style.fill = "white";
    textBlack[0].style.color = "white";
    textBlack[1].style.color = "white";
  } else {
    btnShareOpen.style.display = "none";
    btnGoUp.style.backgroundColor = "#f5f5f5";
    btnShareOpen.style.backgroundColor = "#f5f5f5";
    textBlack[0].style.color = "#111";
    textBlack[1].style.color = "#111";
    svgBlack[0].style.fill = "#111";
    svgBlack[1].style.fill = "#111";
  }
}

window.addEventListener("scroll", scrollFunction);

//BACK TO TOP PAGE BUTTON

btnGoUp.addEventListener("click", () => {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
});

//FOOTER LIST RESPONSIVE - DISPLAY
const titolo = document.querySelectorAll(".footer-list-header");
const lista = document.querySelectorAll(".footer-list");
