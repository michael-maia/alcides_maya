<!-- ARQUIVO 02 -->
<?php 
session_start();
session_name('secreta_adm');
if($_SESSION['validacao']=='ubu'){
echo 'Bem-vindo '.$_SESSION['login'].' a área secreta dos Administradores<br>';
echo "<a href='deslogar.php'>SAIR</a><br>";
echo "<a href='enviar.php'>ENVIAR IMAGEM</a>";
}
else{
echo "Acesso negado!";
}

?>