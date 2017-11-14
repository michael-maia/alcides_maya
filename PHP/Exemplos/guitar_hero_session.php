<?php session_start(); ?>
<!DOCTYPE html>
<html>
	<head>
	</head>
	<body>
		<form>
			<fieldset>
				<legend>CAMPEONATO</legend>
				<input type="text" placeholder="Nome" name="nome">
				<input type="text" placeholder="Pontos" name="pontos">
				<input type="submit" name="enviar"><br>
			</fieldset>
		</form>
		<h2>JOGADORES</h2>
		<?php
		if(isset($_GET['enviar'])): //as informacoes soh vao aparecer apos o user clicar no botao e enviar os dados
			//guardar os dados nos vetores
			$_SESSION['lista_nomes'][]=$_GET['nome'];
			$_SESSION['lista_pontos'][]=$_GET['pontos'];
			//soh serve pra utilizar nomes curtos ao invés de todo o $_SESSION
			$jog=$_SESSION['lista_nomes'];
			$pont=$_SESSION['lista_pontos'];
			//variavel que recebe o tamanho do vetor $_SESSION['lista_nomes']; | fica variando a cada envio de dados
			$cont=count($jog);
			//aqui acontece a ordenacao do vetor de pontos e dos nomes, para que eles mantenham juntos apos a mudanca
			for($i=0;$i<$cont;$i++)
			{
				for($c=0;$c<($cont-$i);$c++)
				{
					if($pont[$c]<$pont[$c+1])
					{
						$aux=$pont[$c];
						$pont[$c]=$pont[$c+1];
						$pont[$c+1]=$aux;
						//ordenar os nomes tambem para que nao troque os nomes com os pontos
						$aux2=$jog[$c];
						$jog[$c]=$jog[$c+1];
						$jog[$c+1]=$aux2;
					}
				}
			}
			//cria uma tabela onde eh mostrado os pontos apos a ordenacao
			echo "<table>";
			for($i=0;$i<$cont;$i++):
				echo "<tr><td>";
				echo $jog[$i];
				echo "</td><td>";
				echo $pont[$i];
				echo "</td></tr>";
			endfor;
			echo "</table>";
		endif;
		?>
	</body>
</html>