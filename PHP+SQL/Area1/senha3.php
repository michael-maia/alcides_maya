<?php // senha.php
$login = $_POST['login'];
$senha = $_POST['senha'];
$con = new mysqli("localhost","root","","games");
$consulta="select login,senha from clientes
where login='$login' and senha='$senha'";
$r = mysqli_query($con,$consulta) or die("marli");
if(mysqli_num_rows($r)==1){
session_start();
session_name('secreta');
$_SESSION['validacao']=1;
$_SESSION['login']=$login;
header("Location: secreta.php");
}else{
echo "usuario ou senha errados!!!";
}
?>
