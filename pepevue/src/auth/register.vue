<template>

    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>COPENOTHING</title>
    <link rel="icon" href="resources/logo.svg">
    <link rel="stylesheet" href="signup.css">
</head>
<body>
    <div class="hero">
            <div class="topmenu">
                <img src="../images/CCC.png" id="ccc">
                <div class="switch">
                <a href="../mainmenu/copenothing.php">HOME</a>
                <a href="../catalog/catalog.php">SHOP</a>
                <a>ABOUT</a>
                <a href="signIn.php" id="homeimg">SIGN IN</a>
                <a href="../mainmenu/exit-db.php">Exit</a>
            </div>
            <div class="logo">
                <a class="right"><img src="../images/search.png" > </a>
                <a class="right"><img src="../images/cart.png"></a>
                <a class="right" id="connect">CONNECT WALLET</a>
            </div>
        </div>
        <h1 id="auth">Register</h1>
        <div class="labels">
        <form action="signup-db.php" method="POST">
                <input type="text" name="surnameUser" placeholder="Surname" required>
                <input type="text" name="nameUser" placeholder="Name" required>
                <input type="text" name="patronymicUser" placeholder="patronymic">
                <input type="text" name="loginUser" placeholder="Login" required>
                <input type="password" name="passwordUser" placeholder="Password" required>
            <p>Согласие на обработку персональных данных <input type="checkbox" name="soglasieUser" id="check" required></p>
            <button>Register</button>
            <p>No account?<a href="../auth/signIn.php">Auth</a></p>
        </form>
    </div>
    </div>
</body>
</html>
</template>

<style>
#app {
  width: 100%;
  margin: 0;
  padding: 0;
}
* {
    box-sizing: content-box;
}
html, body {
    margin: 0;
    padding: 0;
}
body
{
    background-color: #87E464;
}

@font-face {
    font-family: KronaOne;
    src: url(../fonts/KronaOne-Regular.ttf);
}
@font-face {
    font-family: RubikBubbles;
    src: url(../fonts/RubikBubbles-Regular.ttf);
}
@font-face {
    font-family: PoppinsRegular;
    src: url(../fonts/Poppins/Poppins-Regular.ttf);
}
.hero
{
    width: 100%;
    height: 900px;
    background-color: #87E464;
    flex-direction: row;
}
a
{
    text-decoration: none;
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
.switch {
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
#auth
{
    display: flex;
    justify-content: center;
    align-items: center;
    font-family: RubikBubbles;
    font-size: 44px;
    -webkit-text-stroke: 2px white;
}
.labels
{
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: #FFFFFF;
    border-radius: 30px;
    width: fit-content  ;
     margin: 0 auto;
}
.labels form
{
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 30px;
}
.labels input
{
    background-color: #F5F5F5;
    border-radius: 15px;
    width: 350px;
    height: 52px;
    margin-bottom: 10px;
    padding-left: 1%;
    font-family: PoppinsRegular;
    outline: none;
    border: none;
}
.labels button
{
    background-color: #87E464;
     border-radius: 150px;
    width: 320px;
    height: 48px;
    font-family: KronaOne;
    border: none;
    outline: none;
    cursor: pointer;
}
p{
    display: flex;
    justify-content: center;
    align-items: center;
    font-family: KronaOne;
}
#check
{
    font-family: KronaOne;
    width: 20px;
    height: 20px;
}
</style>
