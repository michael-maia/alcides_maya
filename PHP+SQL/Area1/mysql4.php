<!-- ARQUIVO 09 -->
<form method="post" action="" name="form">
	NOME
	<input type="text" name="nome">
	CIDADE
	<input type="text" name="cidade">
	<input type="submit" value="Enviar">
</form>
<?php
$nome=$_POST["nome"];
$cidade=$_POST["cidade"];
$con=new mysqli("localhost","root","","games"); //IP do servidor | usuário | senha | nome do bando de dados
$inserir="insert into clientes (nome,cidade) values ('$nome','$cidade')";
$r=mysqli_query($con,$inserir) or die("Houve um erro!");
echo "Informações adicionadas com sucesso!";
?>