<!-- ARQUIVO 01 -->
<?php
$login=$_POST['login'];
$senha=$_POST['senha'];
$con = new mysqli("localhost","root","","games");
$consulta="select login,senha from clientes where login='$login' and senha='$senha'";
$r=mysqli_query($con,$consulta) or die("erro");
if(mysqli_num_rows($r)==1){
	if($login=='adm'){
	session_start();
	session_name('secreta_adm');
	$_SESSION['validacao']='ubu';
	$_SESSION['login']=$login;
	header("Location:secreta_adm.php");
	}else{
	session_start();
	session_name('secreta');
	$_SESSION['validacao']='aba';
	$_SESSION['login']=$login;
	header("Location:secreta.php");
	}
}
else{
echo "Login ou Senha errados!";
}
?>