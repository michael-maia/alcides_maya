<!-- ARQUIVO 03 -->
<?php
session_start();
session_name("secreta");
unset($_SESSION['validacao']); // unset esvazia a variável, fazendo com que o usuário tenha que logar novamente
unset($_SESSION['login']);
session_destroy();
header("Location:index.php");
?>