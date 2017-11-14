<!-- ARQUIVO 07 -->
<?php
$con= new mysqli("localhost","root","","games"); //conexão com o servidor / escolher do banco de dados
$r=mysqli_query($con,"select nome from clientes"); //comando SQL para solicitar as informações da tabela
?>
<form id="form'" name="form1" method="post" action="">
	<label>
	<select name="select" id="select">
<?php
while($linha=mysqli_fetch_assoc($r)){ //"mysqli_fetch_assoc" serve para pegar os dados e colocar no vetor
	$nome=$linha["nome"];
	echo "<option value=$nome>$nome</option>";
}
?>
</select>
</label>
<input type="submit" value="Enviar">
</form>



