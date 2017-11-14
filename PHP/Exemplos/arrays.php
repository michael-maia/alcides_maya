<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8">
	<head>
	<body>
		<form method="post">
			<label>Player 1</label>
			<input name="p1" type="text">
			<input name="score1" type="text" placeholder="Pontos">
			<br>
			<label>Player 2</label>
			<input name="p2" type="text">
			<input name="score2" type="text" placeholder="Pontos">
			<br>
			<label>Player 3</label>
			<input name="p3" type="text">
			<input name="score3" type="text" placeholder="Pontos">
			<br>
			<label>Player 4</label>
			<input name="p4" type="text">
			<input name="score4" type="text" placeholder="Pontos">
			<br>
			<label>Player 5</label>
			<input name="p5" type="text">
			<input name="score5" type="text" placeholder="Pontos">
			<br>
			<input type="submit">
		</form>
		<p>
			<?php
			//---------------------------------------------------------------------------------------------------			
			$x=array("olá","adeus");
			echo $x[1];
			$x[]="se pá"; //Adiciona valor a ultima posicao
			
			echo '<br>';
			
			$y=array("nome"=>"joão","endereço"=>"rua 2","valor_devido"=>23); //Posicao => Valor
			echo $y["nome"];
			echo $y["valor_devido"];
			
			echo '<br>';
			
			$z=array();
			$z['cores']=array('azul','vermelho','branco','preto');
			$z['modelo']='celta';
			echo $z['cores'][1]; //Exemplo de echo de um vetor bidimensional
			$z['adicionais'][]='ar'; //Acrescentando valor à ultima coluna da linha 'adicionais'
			$z['adicionais'][]='vidro'; //Acrescentando valor à ultima coluna da linha 'adicionais'
			echo $z['adicionais'][0];
			
			//----------------------------------------------------------------------------------------------------
			
			$jog[0]=$_POST['p1']; $pont[]=$_POST['score1'];
			$jog[1]=$_POST['p2']; $pont[]=$_POST['score2'];
			$jog[2]=$_POST['p3']; $pont[]=$_POST['score3'];
			$jog[3]=$_POST['p4']; $pont[]=$_POST['score4'];
			$jog[4]=$_POST['p5']; $pont[]=$_POST['score5'];
			
			for($i=0;$i<10;$i++)
			{
				if($pont[$i]<$pont[$i+1])
				{
					$aux=$pont[$i];
					$pont[$i]=$pont[$i+1];
					$pont[$i+1]=$aux;
					
					$aux2=$jog[$i];
					$jog[$i]=$jog[$i+1];
					$jog[$i+1]=$aux2;
					
				}
			}
			
			
			?>
		</p>
	</body>
</html>
