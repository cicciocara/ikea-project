* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

.upper-nav {
  min-width: 100vw;
  background-color: black;
  padding: 10px 0;
  display: flex;
  justify-content: center;
  align-items: center;
}
.upper-nav img {
  width: 18px;
  height: 100%;
  margin-right: 10px;
  color: white;
  fill: white;
}
.upper-nav .promo {
  color: white;
  font-size: 1rem;
  text-decoration: none;
}
.upper-nav .promo:hover {
  text-decoration: underline;
}

.lower-nav {
  width: fit-content;
  padding: 20px;
  display: grid;
  column-gap: 20px;
  place-items: center;
  grid-template-areas: "menu logo search-bar box1 box2 accesses";
}
.lower-nav .menu {
  grid-area: menu;
  width: 23px;
  height: 23px;
  justify-self: center;
  align-self: center;
  border: none;
  margin: 0 20px;
  background-color: white;
}
.lower-nav .logo {
  grid-area: logo;
  width: 90px;
  height: 36px;
  border: none;
  justify-self: center;
  align-self: center;
}
.lower-nav .search-bar {
  grid-area: search-bar;
  display: flex;
  background-color: whitesmoke;
  padding: 18px;
  border: 1px solid black;
  border-radius: 50px;
  border: none;
  min-width: 40vw;
}
.lower-nav .search-bar:hover {
  background-color: #dfdfdf;
}
.lower-nav .search-bar:hover input {
  background-color: #dfdfdf;
}
.lower-nav .search-bar:hover button {
  background-color: #dfdfdf;
}
.lower-nav .search-bar:hover button img {
  background-color: #dfdfdf;
}
.lower-nav .search-bar img {
  width: 22px;
  height: 20px;
  margin-right: 12px;
}
.lower-nav .search-bar input {
  border: none;
  font-size: 1.1rem;
  width: 100%;
  background-color: whitesmoke;
}
.lower-nav .search-bar button {
  width: 30px;
  border: none;
  background-color: whitesmoke;
}
.lower-nav .search-bar button img {
  background-color: whitesmoke;
  width: 22px;
  height: 20px;
}
.lower-nav .right-nav {
  max-width: 100%;
  display: flex;
  column-gap: 20px;
}
.lower-nav .right-nav .left-nav-box {
  grid-area: box1;
  display: flex;
  min-width: fit-content;
}
.lower-nav .right-nav .left-nav-box .insert-code .information {
  font-size: 0.8rem;
}
.lower-nav .right-nav .left-nav-box .insert-code .insert {
  color: black;
  text-decoration: none;
}
.lower-nav .right-nav .left-nav-box .insert-code .insert:hover {
  text-decoration: underline;
}
.lower-nav .right-nav .left-nav-box img {
  width: 22px;
  height: 22px;
  align-self: end;
  margin-right: 10px;
}
.lower-nav .right-nav .right-nav-box {
  grid-area: box2;
  display: flex;
  min-width: fit-content;
}
.lower-nav .right-nav .right-nav-box .insert-code .information {
  font-size: 0.8rem;
}
.lower-nav .right-nav .right-nav-box .insert-code .insert {
  color: black;
  text-decoration: none;
}
.lower-nav .right-nav .right-nav-box .insert-code .insert:hover {
  text-decoration: underline;
}
.lower-nav .right-nav .right-nav-box img {
  width: 22px;
  height: 22px;
  align-self: end;
  margin-right: 10px;
}
.lower-nav .right-nav .accesses {
  grid-area: accesses;
  height: 100%;
  min-width: fit-content;
  margin-left: 20px;
  align-self: end;
  display: flex;
  column-gap: 20px;
}
.lower-nav .right-nav .accesses button {
  width: 24px;
  height: 24px;
  border: none;
  background-color: white;
}

ul {
  display: flex;
  margin-left: 10vw;
}

/*# sourceMappingURL=homepage.cc.map */
