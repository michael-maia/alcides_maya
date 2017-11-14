<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="UTF-8">
	</head>
	<body>
		<form method="get">
		<h4>LAJOTA</h4>
		<label>Comprimento/Largura (m)</label>
		<input type="text" name="comp_laj">
		/
		<input type="text" name="larg_laj">
		<br>
		<h4>PAREDE</h4>
		<label>Comprimento/Largura (m)</label>
		<input type="text" name="comp_par">
		/
		<input type="text" name="larg_par">
		<br>
		<input type="submit">
		</form>
		<p>
			<?php
			$comp_laj=$_GET['comp_laj'];
			$larg_laj=$_GET['larg_laj'];
			$comp_par=$_GET['comp_par'];
			$larg_par=$_GET['larg_par'];
			$area_laj=$comp_laj*$larg_laj;
			$area_par=$comp_par*$larg_par;
			
			echo 'Num de Lajotas (round) = ',round($area_par/$area_laj),'<br>'; // FUNCAO PARA ARREDONDAR UM NUMERO 
			echo 'Num de Lajotas (ceil) = ',ceil($area_par/$area_laj),'<br>'; // ARREDONDA P/ CIMA 
			echo 'Num de Lajotas (floor) = ',floor($area_par/$area_laj),'<br>'; // ARREDONDA P/ BAIXO 
			echo 'Num de Lajotas (round com 4 casas decimais) = ',round($area_par/$area_laj,4); // ARREDONDA A ENÉSIMA CASA APÓS A VÍRGULA
			
			?>
		</p>
	</body>
</html>