<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="UTF-8">
	</head>
	<body>
		<form method="get"> <!-- Formulario usa a variavel global $_GET pra puxar os dados pro PHP -->
		<label>Numero 1</label>
		<input type="number" name="num1">
		<br>
		<label>Numero 2</label>
		<input type="number" name="num2">
		<br>
		<input type="submit">
		<p>
			<?php
			$x=$_GET['num1']; // Atribui o dado recebido no primeiro input que tem a ID 'num1' 
			$y=$_GET['num2']; // Atribui o dado recebido no segundo input que tem a ID 'num2'
			$soma=$x+$y; // Exemplo de operacao entre variaveis
			$subtracao=$x-$y;
			$vezes=$x*$y;
			$divisao=$x/$y;
			echo 'Soma: ',$soma,'<br>'; //Exemplo de como utilizar o valor da variavel no meio de uma string
			echo 'Subtração: ',$subtracao,'<br>'; // Sempre que for usar uma tag de HTML5, colocar ela dentro do echo
			echo 'Multiplicação: ',$vezes,'<br>';
			echo 'Divisão: ',$divisao,'<br>';
			?>
		</p>
	</body>
</html>