<?php //codigo php para gerar uma galeria de imagens
$con=new mysqli("localhost","root","","nome do banco");
$consulta="select foto from clientes";
$r=mysqli($con,$consulta) or die("Erro");
while($linha=mysqli_fetch_assoc($r)){
	$foto=$linha["foto"];
	echo "<section class='destaque'>
			<img src='$foto'>
		  </section>";
}
?>