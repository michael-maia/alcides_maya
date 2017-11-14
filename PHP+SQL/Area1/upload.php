<?php
$codigo=$_GET['codigo'];
$nome = $_FILES['arquivo']['name'];
$dir = "C:/htdocs/Luan/".$nome;
if(move_uploaded_file($_FILES['arquivo']['tmp_name'],$dir))
{
$con=new mysqli("localhost","root","","games");
$altera="update clientes set imagem='$nome' where codigo='$codigo'";
$r=mysqli_query($con,$altera) or die("erro");
header("Location:consulta.php");
}else{
echo "erro ao enviar!!!";
}
?>