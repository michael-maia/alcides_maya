<?php // consulta.php
$con = new mysqli("localhost","root","","games");
$consulta="select nome,endereco,cidade,codigo,imagem from clientes";
$r = mysqli_query($con,$consulta) or die("erro ao consultar");
while($linha = mysqli_fetch_assoc($r)){
$imagem = $linha['imagem'];
$codigo = $linha['codigo'];
echo "<img src='$imagem' height='75' width='75'  /><br>";
echo "<a href='enviar.php?codigo=$codigo' >Alterar Foto</a> <br>";
echo $linha['nome']."<br>";
echo $linha['endereco']."<br>";
echo $linha['cidade']."<br>";
echo "<br> <br>";
}

?>