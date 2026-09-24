<template>
<body>
    <div>
        <div class="hero">
            <div class="topmenu">
                <img src="../images/CCC.png" id="ccc">
                <div class="switch">
                    <a id="homeimg">HOME</a>
                <a href="../catalog/catalog.php">SHOP</a>
                <a>ABOUT</a>
                <a href="../auth/signIn.php" >SIGN IN</a>
                <a href="exit-db.php" >Exit</a>
            </div>
            <div class="logo">
                <a class="right"><img src="../images/search.png" > </a>
                <a class="right" href="korzina.php"><img src="../images/cart.png"></a>
                <a class="right" id="connect">CONNECT WALLET</a>
            </div>
            <img id="tshirt" src="../images/tshirt.svg">
            <a id="Merchstore">MERCH STORE</a>
            <img id="copenothing" src="../images/copenothing.svg">
            <img src="../images/cap.svg" id="cap">
            <a id="shopnow" href="../catalog/catalog.php">SHOP NOW</a>
            <img src="../images/pepe1.svg" id="pepe1">
            <img src="../images/pepe2.svg" id="pond">
        </div>

        <p></p>

    </div>
    <div class="content">
            <a id="featured">FEATURED ITEM</a>
            <a id="all">ALL</a>
                <div class="strelki">
                    <div class="leftstrelka">
                        <img src="../images/uil--angle-left.png">
                    </div>
                    <div class="rightstrelka" >
                        <img src="../images/uil--angle-left.png">
                    </div>
                </div>
    </div>
    <div class="cartochki">

        </div>
<div class="about">
    <div class="abouthorizontal">
        <img src="../images/about.png" id="about1">
</div>
        <div class="about2">
            <div class="about02">
                <h2>ABOUT</h2>
                <h2 id="cope">COPENOTHING</h2>
            </div>
            <p>Are you ready for COPE? Our team has worked hard to create a unique merch for pepe & pndc holders. All our products are manufactured using the most modern technologies and high-quality materials. They are not only stylish and unique, but also comfortable to use. We strive to provide our customers with a high level of satisfaction and joy from shopping.</p>
                <a id="twit">TWITTER</a>
        </div>
    </div>
   <div class="cards2">
    <div class="buttons">
        <a id="how">HOW TO BUY</a>

        <div class="strelki1">
            <div class="leftstrelka">
                <img src="../images/uil--angle-left.png">
            </div>
            <div class="rightstrelka">
                <img src="../images/uil--angle-left.png">
            </div>
        </div>
    </div>

</div>
<div class="cards3">
    <div class="card">
        <img src="../images/card1.png" id="cardimg">
        <a id="selectproduct">SELECT PRODUCT</a>
    </div>
     <div class="card">
        <img src="../images/card2.png" id="cardimg">
        <a id="selectproduct">ADD TO CART</a>
    </div>
     <div class="card">
        <img src="../images/card3.png" id="cardimg">
        <a id="selectproduct">CHECKOUT</a>
    </div>
     <div class="card">
        <img src="../images/card4.png" id="cardimg">
        <a id="selectproduct">PAYMENT</a>
    </div>
</div>
<div>
     <div class="buttons" style="
    padding: 0 25px;">
        <a id="how">NEWS DROP</a>
        <a id="how" style="margin-left: 20px;">ALL</a>
        <div class="strelki1">
            <div class="leftstrelka">
                <img src="../images/uil--angle-left.png">
            </div>
            <div class="rightstrelka">
                <img src="../images/uil--angle-left.png">
            </div>
        </div>
</div>
    <div class="cartochki" >

    </div>
    <div class="token">
        <div class="token1" >
            <div >
                <h2>TOKEN <span style="color: #87E464;">$PNDC</span></h2>
            </div>
            <p>PNDC it's a token drived by early adopters of PEPE which <br> according to the Pauly0x (founder) will change the game <br> once and for all!</p>
            <a id="twit">TOKEN CONTRACT ^</a>
        </div>
        <img src="../images/token.png">
    </div>
      <div class="tokenpis">
          <img src="../images/pepepis.png">
        <div class="token2" >
            <div >
                <h2>TOKEN <span style="color: #87E464;">$PEPE</span></h2>
            </div>
            <p>PEPE is a deflationary memecoin launched on Ethereum. The <br> cryptocurrency was created as a tribute to the Pepe the Frog <br> internet meme, created by Matt Furie, which gained popularity <br> in the early 2000s.</p>
            <a id="twit">TOKEN CONTRACT ^</a>
        </div>
    </div>
    <div class="clothes">
        <div class="cap">
            <img src="../images/cap.png"  >
            <div class="captitle">
                <p>CAPS</p>
                <a>></a>
            </div>
        </div>
        <div class="tshirt">
        <img src="../images/tshirt.png">
        <div class="tshirtitle">
            <p>T SHIRTS</p>
            <a>></a>
        </div>
        </div>
    </div>
</div>
<div class="end">
    <div class="endhorizontal">
        <img src="../images/left.png">
        <div class="end2">
            <div class="endhorizontal2">
                <p>SHOP</p>
                <p>COPENOTHING</p>
                <p>HOW TO BUY</p>
                <p>TOKENS</p>
            </div>
            <div class="other2">
                <p>ARE THERE ANY ISSUE WITH <br> THE DELIVERY OR PAYMENT <br>CONFIRMATION?</p>
                <a>CONTACT SUPPORT</a>
            </div>
        </div>
    </div>
    <div class="end3horizontal">
        <p>Copyright 2023 CopeNothing. All rights reserved</p>
        <p>Terms of service</p>
        <p>Privacy policy</p>
    </div>
</div>
    </div>
</body>
</template>

<style>
body
{
    background-color: #87E464;;
}

@font-face {
    font-family: KronaOne;
    src: url(../fonts/KronaOne-Regular.ttf);
}
@font-face {
    font-family: RubikBubbles;
    src: url(../fonts/RubikBubbles-Regular.ttf);
}
.hero
{
    width: 100%;
    height: 900px;
    background-color: #87E464;
    flex-direction: row;
}

.topmenu
{
    display: flex;
    width: 100;
    height: 80px;
    align-items: center;
    justify-content: space-between;
}
.topmenu a
{
     color: black;
    text-decoration: none;
}
#ccc
{
    width: 64px;
    height: 60px;
}
.switch
{
    display: flex;
    background-color: white;
    width: 520px;
    height: 52px;
    font-family: KronaOne;
    border-radius: 150px;
    padding: 4px;
    gap: 3px;
    justify-content: center;
    align-items: center;
    text-decoration: none;
    color: black;

}
#sign
{
    color: black;
}
#homeimg
{
    color: white;
    background-color: black;
    border-radius: 40px;
}
.switch a
{
    padding-right: 16px;
    padding-left: 16px;
    padding-top: 12px;
    padding-bottom: 12px;
    background-color: white;
    width: 67px;
    height: 20px;
    font-size: 17px;
    line-height: 20px;
    align-items: center;
    white-space: nowrap;
    justify-content: space-between;
}
.switch a:hover
{
    background-color: black;
    color: white;
    border-radius: 40px;
}

.logo
{
    display: flex;
    gap: 3px;
}
.logo
{
    display: flex;
    align-items: center;
    gap: 3px;
    height: 52px;
    width: 367px;
}
.right
{
    display: flex;
    align-items: center;
    justify-content: center;
    background-color: white;
    border-radius: 50%;
    width: 52px;
    height: 52px;
}
#connect
{
    background-color: white;
    color: black;
    width: 247px;
    height: 52px;
    font-family: KronaOne;
    text-wrap: nowrap;
    font-size: 15px;
    border-radius: 40px;
    font-weight: bold;
}
#tshirt
{
    position: absolute;
    width: 257px;
    height: 272px;
    top: 95px;
    left: 207px;
}
#Merchstore
{
    position: absolute;
    width: 397px;
    height: 44px;
    top: 228px;
    left: 651px;
    font-size: 44px;
    font-family: RubikBubbles;
    line-height: 44px;

    -webkit-text-stroke: 2px white;
    background: linear-gradient(0 0 0 -2);
}
a
{
    text-decoration: none;
}
#copenothing
{
    position: absolute;
    width: 1504px;
    height: 216px;
    top: 285px;
    left: 48px;
}
#cap
{
    position: absolute;
    width: 283px;
    height: 200px;
    top: 137px;
    left: 1305px;
    rotate: -30;
}
#shopnow
{
    position: absolute;
    display: flex;
    width: 260px;
    height: 38px;
    background: linear-gradient(#525252, #282828);
    top: 559px;
    font-size: 22px;
    line-height: 20px;
    left: 658px;
    gap: 10px;
    padding-left: 40px;
    padding-bottom: 24px;
    padding-right: 40px;
    padding-top: 24px;
    font-family: KronaOne;
    justify-content: center;
    align-items: center;
    border-radius: 50px;
    rotate: -3deg;
    color: white;
    border: 8px solid white;
}
#pepe1
{
    position: absolute;
    width: 476px;
    height: 472px;
    top: 437px;
    left: -55px;
    rotate: 5deg;
}
#pond
{
    position: absolute;
    width: 511px;
    height: 522px;
    top: 428px;
    left: 1089px;
}
.content
{
    display: flex;
    width: 100%;
    gap: 8px;
    height: 152px;
    font-family: KronaOne;
    border-radius: 150px;
    padding: 4px;
    gap: 3px;
}

#featured
{
  margin-top: 100px;
  display: flex;
  align-items: center;
  justify-content: center;
  height: 52px;
  background-color: white;
  border-radius: 150px;
  text-decoration: none;
  color: black;
  font-size: 16px;
  white-space: nowrap;
    width: 268px
}
#all {
    margin-top: 100px;
    height: 52px;
  display: flex;
  align-items: center;
  justify-content: center;
    width: 137px;
  background-color: white;
  border-radius: 150px;
  text-decoration: none;
  color: black;
  font-size: 16px;
  white-space: nowrap;
}

#exit
{
    background-color: white;
    color: black;
}

.strelki
{
    margin-top: 100px;

    display: flex;
    flex-direction: row;
    background-color: white;
    width: 124px;
    height: 52px-webkit-fill-available;
    justify-content: center;
    align-items: center;
    border-radius: 140px;
    margin-left: auto;
}

.leftstrelka
{
 display: flex;
    background-color: #87E464;
    width: 46px;
    height: 46px;
    align-items: center;
    justify-content: center;
    border-radius: 150px;
        margin-right: 18px;
}

.rightstrelka
{
    display: flex;
    background-color: #87E464;
    width: 46px;
    height: 46px;
    align-items: center;
    justify-content: center;
    border-radius: 150px;
    transform: scaleX(-1);
}

.cartochka1
{
    display: flex;
    background-color: white;
    flex-direction: column;
    height: 500px;
    width: 380px;
    border-radius: 50px;
}
.cartochka1 img
{
    display: flex;
    width: 380px;
    height:300px;
    align-items: center;
    justify-content: center;
}
.cartochka1 #dvadva
{
        display: flex;
    font-family: KronaOne;
    background-color: #081C0026;
    height: 28px;
    align-items: center;
    border-radius: 15px;
    margin-left: auto;
    margin-right: 20px;
}

.cartochka1 p
{
    display: flex;
    font-family: KronaOne;
    height: 3px;
    margin-left: 15px;
    align-items: center;

}
.cartochka1 #pepka
{
    margin-top: 35px;
}

.divInfo
{
    margin-top: 25px;
    display: flex;
    flex-direction: row;
}
#pepka
{
    text-wrap: nowrap;
}

.divPepka
{
    flex-direction: column;
    display: flex;
    width: 50px;
}

.divBasket {
    display: flex;
    background-color: #87E464;
    border-radius: 150px;
    width: 124px;
    height: 80px;
    margin-left: auto;
        align-items: center;
    justify-content: center;
    margin-right: 10px
}

.divBasket img
{
    display: flex;
    width: 35px;
    align-items: center;
    justify-content: center;
    height: 35px;

}

.cartochki
{
    margin-top: 20px;
    gap: 20px;
    margin-left: 20px;
    display: flex;
}

#hit
{
    display: flex;
    background-color: #FF8C39;
    height: 33px;
    font-size: 12px;
    align-items: center;
    justify-content: center;
    width: 60px;
    border-radius: 40px;
}
#takekorzina
{
    background-color: #87E464;
}
.divBasket img
{
    display: flex;
    width: 35px;
    align-items: center;
    justify-content: center;
    height: 35px;

}

.divBasket {
    display: flex;
    background-color: #87E464;
    border-radius: 150px;
    width: 124px;
    height: 80px;
    margin-left: auto;
        align-items: center;
    justify-content: center;
    margin-right: 10px
}

.divPepka
{
    flex-direction: column;
    display: flex;
    width: 50px;
}
.cartochka1 a
{
    display: flex;
    font-family: KronaOne;
    height: 3px;
    margin-left: 15px;
    color: black;
    align-items: center;
}
.about {
    margin-top: 5%;
    background-color: white;
    font-family: KronaOne;
    border-radius: 50px;
    display: flex;
    flex-direction: row;
    align-items: center;
    padding: 40px;
    gap: 40px;
    width: 1740px;
    height: 544px;
    margin-left: 10px;
}

.abouthorizontal {
    display: flex;
    align-items: center;
    justify-content: center;
    flex-shrink: 0;
}

#about1 {
    width: 584px;
    height: 504px;
    display: flex;
}

#twit
{
    margin-top: 50px;
    display: flex;
    align-items: center;
    justify-content: center;
    width: 320px;
    height: 80px;
    color: black;
    font-family: KronaOne;
    text-decoration: none;
    font-size: 16px;
    border-radius: 40px;
    background-color: #87E464;

}
.about02
{
    display: flex;
    flex-direction: row;
    gap: 15px;
    align-items: center;
     font-size: 49px;
    margin-bottom: 100px;
}
#cope
{

    color: #87E464;
}
.buttons
{
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: space-between;
}
.cards2 {
    width: 100%;
    padding: 0 10px;
    box-sizing: border-box;
}

.buttons {
    width: 100%;

    display: flex;
    justify-content: space-between;
    align-items: center;

    padding: 0 10px;
    box-sizing: border-box;
}

#how {
    display: flex;
    align-items: center;
    justify-content: center;
    height: 52px;
    background-color: white;
    border-radius: 150px;
    color: black;
    font-size: 16px;
    width: 268px;
    font-family: KronaOne;
}
.cards2
{
    padding-top: 20px;
    display: flex;
    flex-direction: row;

}
.cards3 {
    margin-top: 40px;
    display: flex;
    padding: 0 10px;
    gap: 30px;
      width: 1740px;
    margin-left: 50px;
}

.card {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;

    width: 450px;
    height: 550px;

    background-color: white;
    border-radius: 50px;
    font-family: KronaOne;
}


#selectproduct {
    margin-top: 40px;

    display: flex;
    align-items: center;
    justify-content: center;

    width: 280px;
    height: 70px;

    border-radius: 40px;

    color: black;
    font-size: 18px;
}
.strelki1 {
    display: flex;
    flex-direction: row;
    background-color: white;

    width: 124px;
    height: 52px;

    margin-left: auto;
    justify-content: center;
    align-items: center;

    border-radius: 140px;
}
#cardimg
{
    width: 340px;
    height: 340px;
}

.buttons
{
margin-top: 20px;
}
.token
{
    background-color: white;
    width: 1820px;
    height: 590px;
    border-radius: 50px;
    display: flex;
    flex-direction: row;
    font-family: KronaOne;
    justify-content: center;
    align-items: center;
    margin-top: 30px;
    margin-left: 10px;

}
.token img
{
    width: 750px;
    height: 570px;
    padding-right: 30px;
    padding-left: 300px;
    border-radius: 70px;
}
.token1
{
    padding-left:100px;
    padding-right: 100px;
}

.token2
{
    padding-right:300px;
}
.tokenpis
{
    background-color: white;
    width: 1820px;
    height: 590px;
    border-radius: 50px;
    display: flex;
    flex-direction: row;
    font-family: KronaOne;
    justify-content: center;
    align-items: center;
    margin-top: 30px;
    margin-left: 10px;


}

.tokenpis img
{
    width: 720px;
    height: 550px;
    padding-left: 30px;
    padding-right: 200px;
    border-radius: 70px;
}
.clothes {
    display: flex;
    justify-content: center;
    flex-direction: row;
    padding-top: 30px;
}

.cap, .tshirt {
    width: 860px;
    height: 720px;
    background-color: white;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    align-items: center;
    border-radius: 40px;
    margin: 30px;
}

.captitle, .tshirtitle {
    display: flex;
    align-items: center;
    gap: 10px;
    padding: 20px;
    font-family: KronaOne;
    font-size: 28px;
}

.cap a, .tshirt a {
    background-color: #87E464;
    width: 100px;
    height: 60px;
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 35px;
}
.captitle p, .tshirtitle p {
    color: black;
}
.end
{
    margin-top: 20px;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: white;
    flex-direction: column;
    width: 100%;
    height: 720px;
    border-radius: 35px;
}
.endhorizontal
{
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: center;
}
.endhorizontal img
{
    width: 700px;
    height: 580px;
    border-radius: 30px;
    padding-top: 70px;
    padding-left: 40px;
}
.endhorizontal2
{
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: row;
    background-color: white;
    border-radius: 30px;
    width: 1000px;
}
.end2
{
  margin-top: 70px;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    width: 70%;
    height: 565px;
    margin-left: 10px;
    border-radius: 30px;
    border: solid #F5F5F5 10px;

}
.endhorizontal2 p
{
    margin: 10px;
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: #F5F5F5;
    font-family: KronaOne;
    border-radius: 30px;
    height: 140px;
    width: 225px;
}
.other2
{
    background-color: white;
    width: 1050px;
    height: 435px;
    display: flex;
    border-radius: 30px;
    justify-content: center;
    align-items: center;
    font-family: KronaOne;
    flex-direction: column;
    font-size: 17px;
}
.other2 a
{
    display: flex;
    background-color: #87E464;
    width: 290px;
    height: 60px;
    margin-top: 20px;
    justify-content: center;
    align-items: center;
    border-radius: 30px;
}
.end3horizontal{
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    font-family: KronaOne;
    font-size: 24px;
    width: 1700px;
    margin: 20px;
    background-color: #87E464;
    border-radius: 30px;
    margin-bottom: 50px;
    margin-right: 140px;
    text-transform: uppercase;
}
</style>
