header {
  width: 84%;
  margin-left: 11%;
}
header hr {
  border-top: 0;
  margin-bottom: 1rem;
  color: #dfdfdf;
}

.discountCodeLine {
  display: flex;
  align-items: center;
  justify-content: center;
  height: 2.5rem;
  background-color: black;
}
.discountCodeLine svg {
  width: 18px;
  height: 18px;
  margin-right: 0.8rem;
}
.discountCodeLine a {
  color: white;
  text-decoration: none;
  font-size: 0.8rem;
}
.discountCodeLine a:hover {
  text-decoration: underline;
  color: #dfdfdf;
}

.side-btn-menu {
  position: fixed;
  top: 7.5vh;
  left: 5.5%;
}
.side-btn-menu button {
  width: 34px;
  height: 34px;
  border-radius: 50%;
  background-color: transparent;
  border-style: none;
}
.side-btn-menu button img {
  margin-top: 3px;
  width: 24px;
}
.side-btn-menu button:hover {
  background-color: #f4f3f3;
}

.icon-style {
  width: 24px;
}

.headerFirstLine {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding-top: 1.2rem;
}

.logo-ikea {
  width: 90px;
  height: 36px;
}

/*SEARCHBAR*/
.searchBar {
  display: flex;
  align-items: center;
  position: relative;
  width: 75%;
}
.searchBar input {
  margin: 0;
  padding: 0 2rem 0 3rem;
  outline: none;
  border-style: none;
  border-radius: 30px;
  font-size: 1rem;
  height: 3.4rem;
  width: 100%;
  background-color: #f4f3f3;
}

.btnSearch {
  position: absolute;
  border-radius: 50%;
  width: 34px;
  height: 34px;
  right: 1rem;
  z-index: 2;
  border: none;
  cursor: pointer;
  background-color: transparent;
}
.btnSearch:hover {
  background-color: #dfdfdf;
}
.btnSearch img {
  padding-top: 3px;
}

.serarchIcon {
  position: absolute;
  top: 0.98rem;
  left: 1rem;
}

.headerFirstLine {
  margin-bottom: 0.6rem;
}
.headerFirstLine nav {
  display: flex;
}
.headerFirstLine nav button {
  border-radius: 50%;
  border-style: none;
  background-color: transparent;
  width: 40px;
  height: 40px;
  padding: 2px;
  display: flex;
  justify-content: center;
  align-items: center;
}
.headerFirstLine nav button:hover {
  background-color: #f4f3f3;
}
.headerFirstLine nav .btn-menu-resp {
  display: none;
}

.headerSecondLine {
  margin-bottom: 1rem;
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.product-container a {
  margin-right: 1.5rem;
  color: black;
  font-weight: 600;
  font-size: 0.9rem;
  text-decoration: none;
}
.product-container a:hover {
  text-decoration: underline;
}

.info {
  display: flex;
  gap: 2rem;
}

.info-element {
  display: flex;
  gap: 0.5rem;
}
.info-element div {
  height: 24px;
}
.info-element div a {
  color: black;
  font-weight: 600;
  font-size: 0.9rem;
  text-decoration: none;
}

.path-container {
  margin-top: 1rem;
  display: flex;
  align-items: center;
  font-size: small;
  color: black;
}
.path-container a {
  color: black;
  text-decoration: none;
}
.path-container a:hover {
  text-decoration: underline;
}

.peak-rotation {
  transform: rotate(180deg);
  height: 10px;
}

@media (max-width: 1199px) {
  header {
    width: 94%;
    margin-left: 1.5rem;
    margin-right: 1.5rem;
  }

  .side-btn-menu {
    display: none;
  }
}
footer {
  margin-top: 3rem;
  padding-left: 11%;
  padding-top: 3rem;
  padding-right: 7vw;
  padding-bottom: 1.5rem;
  background-color: #f1f1f1;
  display: grid;
  justify-content: space-between;
  grid-template-areas: "family contact buy acount about" "business contact buy acount about" "pay pay pay pay pay" "info info info info info";
  row-gap: 2rem;
  column-gap: 2.5rem;
}
footer .footer-list {
  list-style: none;
  padding-left: 0;
}
footer .footer-list li {
  padding-top: 0.6rem;
  padding-bottom: 0.6rem;
  font-size: 0.9rem;
}
footer .footer-list li a {
  text-decoration: none;
  color: #111;
}
footer .footer-list li a:hover {
  text-decoration: underline;
}
footer .ikea-family {
  grid-area: family;
  font-size: 0.9rem;
  max-width: 351px;
}
footer .ikea-family h4 {
  font-size: 1.1rem;
  margin-bottom: 0;
}
footer .ikea-family span a {
  font-size: 0.97rem;
  color: #545353;
}
footer .ikea-family span a:hover {
  color: black;
  font-weight: 500;
}
footer .ikea-business {
  grid-area: business;
  font-size: 0.9rem;
  max-width: 351px;
}
footer .ikea-business h4 {
  font-size: 1.1rem;
  margin-bottom: 0;
}
footer .ikea-business span a {
  font-size: 0.97rem;
  color: #545353;
}
footer .ikea-business span a:hover {
  color: black;
  font-weight: 500;
}
footer .ikea-contact {
  grid-area: contact;
}
footer .ikea-buy {
  grid-area: buy;
}
footer .ikea-account {
  grid-area: acount;
}
footer .ikea-about-us {
  grid-area: about;
}
footer .footer-icons-row {
  grid-area: pay;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
footer .footer-icons-row div {
  display: flex;
  align-items: center;
  gap: 1.5rem;
}
footer .footer-icons-row div .icons-social {
  display: flex;
  gap: 1.5rem;
}
footer .footer-icons-row div .icons-social div {
  border-style: solid;
  border-radius: 50%;
  border-width: 1px;
  border-color: #dfdfdf;
  width: 30px;
  height: 30px;
}
footer .footer-icons-row div .icons-social div img {
  padding-left: 3px;
  padding-top: 5px;
}
footer .footer-icons-row div .icons-social div:hover {
  border-color: #111;
}
footer .footer-icons-row div .icons-pay {
  display: flex;
  gap: 1.5rem;
}
footer .footer-icons-row div .icons-pay div {
  border-style: solid;
  padding: 5px;
  border-width: 1px;
  border-color: #dfdfdf;
}
footer .footer-icons-row div .icons-pay div img {
  height: 24px;
}
footer .ikea-info {
  grid-area: info;
  font-size: 0.75rem;
  line-height: 2;
}
footer .ikea-info section {
  display: flex;
  justify-content: space-between;
}
footer .ikea-info hr {
  border-top: 0;
  margin-bottom: 2rem;
  color: #dfdfdf;
}
footer .footer-list-info {
  list-style: none;
  text-align: right;
}
footer .footer-list-info li {
  display: inline;
  padding-left: 1rem;
}
footer .footer-list-info li a {
  text-decoration: none;
  display: inline;
  color: #111;
}
footer .footer-list-info li a:hover {
  text-decoration: underline;
}
footer .btn-footer {
  height: 45px;
  border-style: none;
  background-color: black;
  border-radius: 30px;
  padding: 0.8rem 1.3rem 0.8rem 1.3rem;
  margin-top: 1rem;
}
footer .btn-footer a {
  text-decoration: none;
  color: white;
  font-size: 0.8rem;
  font-weight: bold;
}
footer .btn-footer:hover {
  background-color: #4e4d4d;
}
footer .btn-change-country {
  display: flex;
  align-items: center;
  gap: 1rem;
  height: 45px;
  background-color: transparent;
  border-style: solid;
  border-color: #dfdfdf;
  border-radius: 30px;
  padding: 0.8rem 1.3rem 0.8rem 1.3rem;
  margin-top: 0.5rem;
}
footer .btn-change-country img {
  width: 20px;
  height: 20px;
}
footer .btn-change-country a {
  text-decoration: none;
  color: #111;
  font-size: 0.8rem;
  font-weight: bold;
}
footer .btn-change-country:hover {
  border-color: #111;
}

@media (max-width: 1199px) {
  footer {
    padding-left: 1.5rem;
  }
}
@media (max-width: 900px) {
  footer {
    padding: 2rem 2rem 2rem 2rem;
    grid-template-areas: "family" "business" "contact" "buy" "acount" "about" "pay" "info";
  }

  .footer-list {
    visibility: collapse;
    display: none;
  }
}
/*sass gift-style.scss gift-style.css*/
html,
body {
  background-color: red;
  margin: 0;
  font-family: Roboto, "Open Sans", "Helvetica Neue", sans-serif;
}

main {
  max-width: 84%;
  margin-left: 11%;
}

.main-gift-s1 {
  width: 99.4%;
  margin-top: 5rem;
  padding-top: 4rem;
  display: flex;
  justify-content: space-between;
}
.main-gift-s1 article {
  width: 40%;
  padding-right: 1.5rem;
}
.main-gift-s1 article h1 {
  font-size: 2.4rem;
  line-height: 2.7rem;
}
.main-gift-s1 article p {
  color: #484848;
  font-size: 1rem;
  line-height: 1.7rem;
}
.main-gift-s1 div {
  width: 60%;
}
.main-gift-s1 div img {
  width: 100%;
}

.main-gift-s2 {
  margin-top: 3rem;
  margin-bottom: 2rem;
  width: 100%;
  display: flex;
  flex-wrap: wrap;
  gap: 0.6rem;
}
.main-gift-s2 div {
  width: 32.7%;
  max-height: 450px;
}
.main-gift-s2 div a {
  font-size: 1.2rem;
  font-weight: 600;
  text-decoration: none;
  color: black;
}
.main-gift-s2 div a div {
  width: 100%;
  height: 60%;
  overflow: hidden;
  margin-bottom: 2rem;
}
.main-gift-s2 div a div img {
  width: 100%;
  object-fit: cover;
}
.main-gift-s2 div a:hover {
  text-decoration: underline;
}
.main-gift-s2 div .arrow-style {
  width: 24px;
  margin-top: 1rem;
}

.article-s3 {
  margin-top: 2.5rem;
  max-width: 850px;
  font-size: 0.94rem;
  line-height: 1.5rem;
}
.article-s3 h2 {
  font-size: 1.5rem;
}
.article-s3 p {
  color: #484848;
}

.main-gift-s3 {
  width: 100%;
  margin-top: 4rem;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  gap: 0.5rem;
}
.main-gift-s3 div {
  flex-basis: 49%;
}
.main-gift-s3 div img {
  width: 100%;
}
.main-gift-s3 div h3 {
  font-size: 1rem;
  margin-top: 2rem;
}
.main-gift-s3 div p {
  color: #484848;
  font-size: 0.9rem;
  line-height: 1.5rem;
  padding-right: 2rem;
  margin-bottom: 2rem;
}
.main-gift-s3 div button {
  display: flex;
  align-items: center;
  gap: 1rem;
  height: 45px;
  border-style: solid;
  background-color: transparent;
  border-color: #dfdfdf;
  border-radius: 30px;
  padding: 0.8rem 1.3rem 0.8rem 1.3rem;
  margin-top: 0.5rem;
}
.main-gift-s3 div button a {
  text-decoration: none;
  color: #111;
  font-size: 0.8rem;
  font-weight: bold;
}
.main-gift-s3 div button:hover {
  border-color: #111;
}

.main-gift-s4 {
  margin-top: 4rem;
  margin-bottom: 4rem;
  display: flex;
  justify-content: center;
  gap: 1px;
}
.main-gift-s4 div {
  width: 30%;
  padding: 1.5rem;
  background-color: #f1f1f1;
  display: inherit;
  flex-direction: column;
  gap: 0.8rem;
  align-items: center;
}
.main-gift-s4 div svg {
  width: 24px;
  height: 24px;
}
.main-gift-s4 div h3 {
  margin: 0;
  font-size: 1.1rem;
}
.main-gift-s4 div p {
  margin: 0;
}
.main-gift-s4 div a {
  font-size: 0.97rem;
  color: #545353;
}
.main-gift-s4 div a:hover {
  color: black;
  font-weight: 500;
}

.main-gift-s5 {
  width: 80%;
  margin: auto;
  display: flex;
  margin-top: 4rem;
  margin-bottom: 4rem;
  background-color: #142b51;
}
.main-gift-s5 div {
  width: 50%;
}
.main-gift-s5 div img {
  width: 100%;
  object-fit: cover;
}
.main-gift-s5 article {
  width: 40%;
  color: #fff;
  padding: 3rem;
  padding-top: 1rem;
}
.main-gift-s5 article h3 {
  font-size: 1.5rem;
  font-weight: 700;
}
.main-gift-s5 article p {
  font-size: 0.88rem;
  line-height: 1.5rem;
}
.main-gift-s5 article a {
  font-weight: 400;
  color: #fff;
}
.main-gift-s5 article a:hover {
  color: #111;
}
.main-gift-s5 .disclaimer {
  font-size: 0.6rem;
}

/*BUTTONS SHARE & UP - FULLSCREEN*/
.cont-btn-share {
  position: fixed;
  left: 5.5%;
  bottom: 4%;
  z-index: 2;
  display: flex;
  flex-direction: column;
  gap: 2rem;
}
.cont-btn-share div {
  height: 40px;
  min-width: 40px;
  max-width: max-content;
  background-color: #f5f5f5;
  border-radius: 20px;
}
.cont-btn-share div a {
  text-decoration: none;
  color: black;
  font-size: 0.9rem;
  font-weight: 600;
  display: flex;
  align-items: center;
  gap: 1rem;
  height: 40px;
}
.cont-btn-share div a img {
  margin-left: 8px;
  width: 24px;
  height: 24px;
}
.cont-btn-share div a span {
  display: none;
  margin-right: 20px;
}
.cont-btn-share div:hover span {
  display: flex;
}
.cont-btn-share #btn-share {
  display: none;
}

/*BUTTONS SHARE & UP - RESPONSIVE*/
.cont-btn-share-res {
  display: none;
  width: 100%;
}
.cont-btn-share-res hr {
  border-top: 0;
  margin-bottom: 1rem;
  color: #f5f5f5;
}
.cont-btn-share-res div {
  display: flex;
  justify-content: center;
  gap: 0.5rem;
}
.cont-btn-share-res div div {
  height: 40px;
  min-width: 40px;
  max-width: max-content;
  background-color: #f5f5f5;
  border-radius: 20px;
}
.cont-btn-share-res div div a {
  text-decoration: none;
  color: black;
  font-size: 0.9rem;
  font-weight: 600;
  display: flex;
  align-items: center;
  gap: 1rem;
  height: 40px;
}
.cont-btn-share-res div div a img {
  width: 24px;
  height: 24px;
}
.cont-btn-share-res div div a span {
  display: none;
  margin-right: 20px;
}
.cont-btn-share-res div div:hover img {
  margin-left: 8px;
}
.cont-btn-share-res div div:hover span {
  display: flex;
}

@media (max-width: 1199px) {
  main {
    background-color: red;
    margin-left: 0;
    max-width: 100%;
    padding-left: 2rem;
    padding-right: 2rem;
  }

  .main-gift-s1 {
    margin-top: 3rem;
    padding-top: 3rem;
  }

  .main-gift-s2 div {
    width: 49.3%;
  }
  .main-gift-s2 div a div {
    height: 70%;
  }

  .cont-btn-share {
    display: none;
  }

  .cont-btn-share-res {
    display: block;
  }

  .main-gift-s5 {
    display: flex;
    flex-direction: column;
  }
  .main-gift-s5 div {
    width: 100%;
  }
  .main-gift-s5 article {
    width: 100%;
  }
}
@media (max-width: 900px) {
  .main-gift-s1 {
    margin-top: 4rem;
    display: flex;
    flex-direction: column;
  }
  .main-gift-s1 article {
    width: 70%;
    padding-right: 0px;
    margin-bottom: 1rem;
  }
  .main-gift-s1 article h1 {
    font-size: 2rem;
    line-height: 3rem;
  }
  .main-gift-s1 article p {
    font-size: 1rem;
    line-height: 1.5rem;
  }
  .main-gift-s1 div {
    width: 100%;
  }
  .main-gift-s1 div img {
    width: 100%;
  }

  .main-gift-s4 {
    margin-top: 4rem;
    margin-bottom: 4rem;
    display: flex;
    flex-wrap: wrap;
    gap: 1px;
  }
  .main-gift-s4 div {
    width: 100%;
  }
}
@media (max-width: 600px) {
  .main-gift-s1 {
    margin-top: 3rem;
  }
  .main-gift-s1 article {
    width: 100%;
  }

  .main-gift-s2 {
    width: 100%;
    margin-bottom: 2rem;
    gap: 2rem;
  }
  .main-gift-s2 div {
    width: 100%;
    max-height: 350px;
  }
  .main-gift-s2 div a div {
    width: 100%;
    height: 80%;
    margin-bottom: 2rem;
  }
  .main-gift-s2 div a div img {
    width: 100%;
    height: 100%;
    object-fit: cover;
  }

  .article-s3 {
    width: 100%;
  }
  .article-s3 h2 {
    font-size: 1.2rem;
  }

  .main-gift-s3 {
    margin-top: 2rem;
    flex-direction: column;
    gap: 2rem;
  }

  .main-gift-s4 {
    gap: 1px;
  }
  .main-gift-s4 div {
    align-items: flex-start;
  }
}
@media (max-width: 400px) {
  .main-gift-s1 {
    margin-top: 3rem;
  }
  .main-gift-s1 article {
    width: 100%;
  }
  .main-gift-s1 article h1 {
    font-size: 1.5rem;
    line-height: 2rem;
  }

  .main-gift-s2 div a div {
    height: 60%;
    margin-bottom: 1rem;
  }
}

/*# sourceMappingURL=gift-style.cs.map */
