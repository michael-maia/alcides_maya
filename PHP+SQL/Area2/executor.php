<?php
include "banco.php";
$ob=new Banco();
$ob->conectar("games");
//$ob->consulta_esp($ob->conectar("games"),"michael");
$ob->incluir($ob->conectar("games"),"MICHAEL2","PORTO ALEGRE@");
?>