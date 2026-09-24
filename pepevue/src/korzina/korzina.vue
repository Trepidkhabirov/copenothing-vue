<template>
<body>
    <div class="hero">
            <div class="topmenu">
                <img src="../images/CCC.png" id="ccc">
                <div class="switch">
                <a href="../mainmenu/copenothing.php">HOME</a>
                <a href="../catalog/catalog.php">SHOP</a>
                <a>ABOUT</a>
                <a href="../auth/signIn.php" id="homeimg">SIGN IN</a>
            </div>
            <div class="logo">
                <a class="right"><img src="../images/search.png" > </a>
                <a class="right" href=""><img src="../images/cart.png"></a>
                <a class="right" id="connect">CONNECT WALLET</a>
            </div>
        </div>
        <div class="cartochki">

</div>
<div class="oformlenie">
    <p>Итоговая стоимость: </p>
    <form action="../buying/buying-db.php" method="post">
        <button type="submit" id="oformit" name="oformit">Оформить заказ</button>
    </form>
</div>
</div>
</body>
</template>
<style>
body
{
    background-color: #87E464;
}
#takekorzina, .divBasket
{
    background-color: red;
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
    flex-direction: row;
}

.topmenu
{
    display: flex;
    width: 100%;
    height: 80px;
    align-items: center;
    justify-content: space-between;
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
    width: 425px;
    height: 52px;
    font-family: KronaOne;
    border-radius: 150px;
    padding: 4px;
    gap: 3px;
    justify-content: center;
    align-items: center;
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
.cartochka1 a
{
    display: flex;
    font-family: KronaOne;
    height: 3px;
    margin-left: 15px;
    color: black;
    align-items: center;
}
.cartochka1 #pepka
{
    margin-top: 35px;
}

.divInfo
{
    margin-top: 15px;
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
    display: flex;
    flex-wrap: wrap;
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


.oformlenie
{
    display: flex;
    align-items: center;
    font-size: 24px;
    justify-content: center;
    flex-direction: column;
    border-radius: 30px;
    background-color: white;
    margin-top: 20px;
    width: 350px;
    height: 140px;
}
#oformit
{
    border: none;
    align-items: center;
    justify-content: center;
    font-family: Krona One;
    border-radius: 30px;
    font-size: 20px;
    width: 270px;
    height: 60px;
    background-color: #87E464;
    margin-bottom: 15px;

}
</style>
