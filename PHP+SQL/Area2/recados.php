<p><img src="alienware.jpg" width="80" height="80"></p>
<form id="form1" name="form1" method="post" action="inserir_recado.php">
	<label>
		NOME
		<input type="text" name="nome" id="text">
	</label>
	<br>
	<label>
		TEXTO
		<textarea name="texto" id="textarea" cols="45" rows="5"></textarea>
	</label>
	<br>
	<p>
	<input type="submit" name="button" id="button" value="Submit">
	</p>
</form>
<?php
$con=new mysqli("localhost","root","","games");
$consultar="select nome,recado from recados order by numero desc";
$r=mysqli_query($con,$consultar) or die("ERRO");
while($linha=mysqli_fetch_assoc($r)){
	echo "Nome: ".$linha['nome']."<br>";
	echo "Recado: ".$linha['recado']."<br><br>";
}
?>