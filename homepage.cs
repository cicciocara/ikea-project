* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  width: 100vw;
  overflow-x: hidden;
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
  display: grid;
  margin-top: 20px;
  grid-template-columns: 8vw 7vw 35vw 33vw 10vw;
  row-gap: 40px;
  column-gap: 20px;
  place-items: center;
  grid-template-areas: "menu logo search-bar information-box accesses" ". sub-nav . . .";
}
.lower-nav .menu {
  grid-area: menu;
  border: none;
  background-color: white;
  display: flex;
  justify-content: center;
  align-items: center;
}
.lower-nav .menu:hover {
  background-color: whitesmoke;
}
.lower-nav .menu img {
  width: 42px;
  background-color: inherit;
  padding: 10px;
  border-radius: 50px;
  position: fixed;
}
.lower-nav .logo {
  grid-area: logo;
  border: none;
  background-color: white;
}
.lower-nav .logo img {
  width: 90px;
  height: 36px;
}
.lower-nav .search-bar {
  grid-area: search-bar;
  width: 100%;
  height: 50px;
  display: flex;
  justify-content: start;
  align-items: center;
  border: none;
  border-radius: 25px;
  padding: 0 10px;
  background-color: whitesmoke;
}
.lower-nav .search-bar:hover {
  background-color: #dedede;
}
.lower-nav .search-bar:hover input {
  background-color: #dedede;
}
.lower-nav .search-bar img {
  width: 24px;
  height: 24px;
}
.lower-nav .search-bar input {
  width: 100%;
  margin-left: 5px;
  font-size: 1.1rem;
  background-color: whitesmoke;
  border: none;
}
.lower-nav .search-bar input:hover {
  background-color: #dedede;
}
.lower-nav .information-box {
  grid-area: information-box;
  display: flex;
  column-gap: 20px;
}
.lower-nav .information-box .code-insert {
  display: flex;
  column-gap: 5px;
}
.lower-nav .information-box .code-insert img {
  grid-area: img;
  align-self: end;
  width: 24px;
}
.lower-nav .information-box .code-insert .insert {
  font-size: 0.9rem;
}
.lower-nav .information-box .code-insert .insert a:hover {
  text-decoration: underline;
}
.lower-nav .information-box .time-view {
  display: flex;
  column-gap: 5px;
}
.lower-nav .information-box .time-view img {
  align-self: end;
  width: 24px;
}
.lower-nav .information-box .time-view .view {
  font-size: 0.9rem;
}
.lower-nav .information-box .time-view .view a:hover {
  text-decoration: undeline;
}

.accesses {
  grid-area: accesses;
  margin-top: 12px;
}
.accesses .user {
  border: none;
  background-color: white;
  margin-right: 5px;
}
.accesses .user:hover {
  background-color: whitesmoke;
  border-radius: 50px;
}
.accesses .user img {
  width: 24px;
}
.accesses .heart {
  width: 32px;
  border: none;
  background-color: white;
  margin-right: 5px;
}
.accesses .heart:hover {
  background-color: whitesmoke;
  border-radius: 50px;
}
.accesses .heart img {
  width: 24px;
}
.accesses .basket {
  width: 32px;
  border: none;
  background-color: white;
  margin-right: 5px;
}
.accesses .basket:hover {
  background-color: whitesmoke;
  border-radius: 50px;
}
.accesses .basket img {
  width: 24px;
}

.sub-nav {
  grid-area: sub-nav;
  display: flex;
  margin-left: 60px;
}
.sub-nav li:first-child {
  list-style: none;
}
.sub-nav li:first-child a {
  text-decoration: none;
  color: black;
}
.sub-nav li:first-child a:hover {
  text-decoration: underline;
}
.sub-nav li:last-child {
  list-style: none;
}
.sub-nav li:last-child a {
  text-decoration: none;
  color: black;
  padding-left: 30px;
}
.sub-nav li:last-child a:hover {
  text-decoration: underline;
}

main {
  margin: auto;
  margin-top: 20px;
  width: 80vw;
  height: 100vh;
}

footer {
  background-color: lightgrey;
  display: grid;
  grid-template-columns: auto;
  grid-template-areas: "box-footer" "footer-nav";
}
footer .box-footer {
  margin: 20px 0;
  grid-area: box-footer;
  display: grid;
  width: 80vw;
  margin: auto;
  grid-template-columns: 2fr repeat(4, 1fr);
  grid-template-areas: "first-box second-box third-box fourth-box fifth-box";
}
footer .footer-nav {
  grid-area: footer-nav;
}

/*# sourceMappingURL=homepage.cs.map */
