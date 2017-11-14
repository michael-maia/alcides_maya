<?php
session_start();
session_name("secret");
include "banco.php";
$ob=new Banco();
$ob->conectar("games");
if($_SESSION["valida"]==1){
	$ob->imagem($_SESSION["login"]);
	echo "<br>Ola ".$_SESSION["login"]." a area secreta!";
	echo "<br><a href='sair.php'>Sair</a>";
	
}
else
	echo "Acesso Negado!!!";
?>