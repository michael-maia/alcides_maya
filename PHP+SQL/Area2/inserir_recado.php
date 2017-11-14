<?php
$nome=$_POST["nome"];
$recado=$_POST["texto"];
if($_POST["nome"]!="" && $_POST["texto"]!=""){
	$con=new mysqli("localhost","root","","games");
	$incluir="insert into recados (nome,recado) values('$nome','$recado')";
	$r=mysqli_query($con,$incluir)or die("Erro");
	echo "Recado inserido com sucesso!";
}
else{
	echo "Preencha ambos os campos!";
}
?>