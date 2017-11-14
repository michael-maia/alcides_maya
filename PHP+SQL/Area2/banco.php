<?php
class Banco{
	public $banco;
	
	function conectar($banco){
		$this->banco=$banco;
		$con=new mysqli("localhost","root","",$banco);
		return $con; //retorna a conexao para ser usada nas outras funcoes
	}
	function consulta($con){
		$consulta = "select nome,cidade from clientes";
		$r=mysqli_query($con,$consulta) or die("\nERRO!");
		while($linha=mysqli_fetch_assoc($r)){
			echo $linha['nome']."<br>";
			echo $linha['cidade']."<br><br>";
		}
	}
	function consulta_esp($con,$nome){
		$consulta = "select nome,cidade from clientes where nome='$nome'";
		$r=mysqli_query($con,$consulta) or die("\nERRO!");
		while($linha=mysqli_fetch_assoc($r)){
			echo $linha['nome']."<br>";
			echo $linha['cidade']."<br><br>";
		}
	}
	/*function incluir($con,$nome,$cidade){   //FALTA ARRUMAR!!!
		echo "<form name='form' method='post'>
				NOME
				<br><input type='text' name='nome' size='40'/><br>
				CIDADE
				<br><input type='text' name='cidade' size='40'/><br><br>
				<input name='submit' type='submit' value='Submit'/><br>
			</form>";
		$nome=$_POST["nome"];
		$cidade=$_POST["cidade"];
		$inserir="insert into clientes (nome,cidade) values ('$nome','$cidade')";
		if(mysqli_query($con,$inserir)=== TRUE)
			echo "Usuário criado!";
	}*/
	function login($con,$login,$senha){
		$consulta="select login,senha from clientes where login='$login' and senha='$senha'";
		$r=mysqli_query($con,$consulta) or die("Erro na consulta!");
		if(mysqli_num_rows($r)==1){
			session_start();
			session_name("secret");
			$_SESSION['valida']=1;
			$_SESSION['login']=$login;
			header("Location:secreta.php");
		}
		else
			echo "Login ou Senha errados!";
	}
	function imagem($login){
		$con=new mysqli("localhost","root","","games");
		$consulta="select imagem from clientes where login='$login'";
		$r=mysqli_query($con,$consulta) or die("Erro na consulta!");
		while($linha=mysqli_fetch_assoc($r)){
			$imagem=$linha['imagem'];
			echo "<a href='altera_imagem.php'><img src='$imagem' height='100' width='100'></a>";
		}
	}
}
?>