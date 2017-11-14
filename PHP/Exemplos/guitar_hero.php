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
			$player1=$_POST['p1']; $score1=$_POST['score1'];
			$player2=$_POST['p2']; $score2=$_POST['score2'];
			$player3=$_POST['p3']; $score3=$_POST['score3'];
			$player4=$_POST['p4']; $score4=$_POST['score4'];
			$player5=$_POST['p5']; $score5=$_POST['score5'];
			
			//SCORES		NOMES
			$pri=$score1; $prin=$player1; //primeiro score / primeiro nome
			$seg=$score2; $segn=$player2; //segundo score / segundo nome
			$ter=$score3; $tern=$player3; //terceiro score / terceiro nome
			$qua=$score4; $quan=$player4; //quarto score / quarto nome
			$qui=$score5; $quin=$player5; //quinto score / quinto nome
			
			
			if($pri<$seg) //1-2
			{
				$aux=$pri; $auxn=$prin; 
				$pri=$seg; $prin=$segn;
				$seg=$aux; $segn=$auxn;
			}
			if($seg<$ter) //2-3
			{
				$aux=$seg; $auxn=$segn; 
				$seg=$ter; $segn=$tern;
				$ter=$aux; $tern=$auxn;
			}
			if($ter<$qua) //3-4
			{
				$aux=$ter; $auxn=$tern; 
				$ter=$qua; $tern=$quan;
				$qua=$aux; $quan=$auxn;
			}
			if($qua<$qui) //4-5
			{
				$aux=$qua; $auxn=$quan; 
				$qua=$qui; $quan=$quin;
				$qui=$aux; $quin=$auxn;
			}
			if($pri<$seg) //1-2
			{
				$aux=$pri; $auxn=$prin; 
				$pri=$seg; $prin=$segn;
				$seg=$aux; $segn=$auxn;
			}
			if($seg<$ter) //2-3
			{
				$aux=$seg; $auxn=$segn; 
				$seg=$ter; $segn=$tern;
				$ter=$aux; $tern=$auxn;
			}
			if($ter<$qua) //3-4
			{
				$aux=$ter; $auxn=$tern; 
				$ter=$qua; $tern=$quan;
				$qua=$aux; $quan=$auxn;
			}
			if($pri<$seg) //1-2
			{
				$aux=$pri; $auxn=$prin; 
				$pri=$seg; $prin=$segn;
				$seg=$aux; $segn=$auxn;
			}
			if($seg<$ter) //2-3
			{
				$aux=$seg; $auxn=$segn; 
				$seg=$ter; $segn=$tern;
				$ter=$aux; $tern=$auxn;
			}
			if($pri<$seg) //1-2
			{
				$aux=$pri; $auxn=$prin; 
				$pri=$seg; $prin=$segn;
				$seg=$aux; $segn=$auxn;
			}

			print "{$prin} = {$pri}<br>";
			print "{$segn} = {$seg}<br>";
			print "{$tern} = {$ter}<br>";
			print "{$quan} = {$qua}<br>";
			print "{$quin} = {$qui}";
		
			?>
		</p>
		
	</body>
</html>
