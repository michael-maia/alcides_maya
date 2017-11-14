<!-- ARQUIVO 06 -->
<form method="post" action="" name="form">
	CIDADE OU NOME
	<input type="text" name="item">
	<input type="submit" value="Enviar">
</form>
<?php
$item=$_POST["item"];
$con= new mysqli("localhost","root","","games"); //conexão com o servidor / escolher do banco de dados
if($item!=""){
	$r=mysqli_query($con,"select codigo,nome,cidade from clientes where cidade like '%$item%' or nome like '%$item%'"); //comando SQL para solicitar as informações da tabela / pesquisa tanto o nome quanto a cidade / % é um caracter especial que significa que ele procura qualquer informação que inicia ou acaba com a pesquisa
}
else{
	$r=mysqli_query($con,"select codigo,nome,cidade from clientes"); //comando SQL para solicitar as informações da tabela
}
while($linha=mysqli_fetch_assoc($r)){ //"mysqli_fetch_assoc" serve para pegar os dados e colocar no vetor
	echo $linha["codigo"]."<br>";
	echo $linha["nome"]."<br>";
	echo $linha["cidade"]."<br><br>";
}
?>
