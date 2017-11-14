<?php
session_start();
session_name("secret");
unset($_SESSION["valida"]);
unset($_SESSION["login"]);
session_destroy();
header("Location:index2.php");
?>
