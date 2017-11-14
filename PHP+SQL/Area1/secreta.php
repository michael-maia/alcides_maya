<!-- ARQUIVO 02 -->
<?php 
session_start();
session_name('secreta');
if($_SESSION['validacao']==1){
echo 'Bem-vindo '.$_SESSION['login'].' a área secreta<br>';
echo "<a href='deslogar.php'>SAIR</a><br>";
echo "<a href='enviar.php'>ENVIAR IMAGEM</a>";
}
else{
echo "Acesso negado!";
}

?>