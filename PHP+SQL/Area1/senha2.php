<!-- ARQUIVO 05 -->
<?php
$login=$_POST['login'];
$senha=$_POST['senha'];
$listaLogin=array("A","B","C","D","E");
$listaSenha=array(1,2,3,4,5);
for($i=0;$i<5;$i++){
	if($login==$listaLogin[$i] && $senha==$listaSenha[$i]){
		session_start();
		session_name('secreta');
		$_SESSION['validacao']=1;
		$_SESSION['login']=$login;
		header("Location:secreta.php");
	}
	
}

	echo "Login ou Senha errados!";
	
?>