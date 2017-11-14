<!-- ARQUIVO 08 -->
<?php
$con=new mysqli("localhost","root","","games");
$inserir="insert into clientes (nome,cidade) values ('B','Porto Alegre')";
$r=mysqli_query($con,$inserir) or die("Houve um erro!");
echo "Informações adicionadas com sucesso!";
?>