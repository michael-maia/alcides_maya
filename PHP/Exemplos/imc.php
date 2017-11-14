<!DOCTYPE html>
<html>
	<head>
		<meta charset="UTF-8">
	</head>
	<body>
		<form method="post">
		<label>Massa</label>
		<input type="text" name="massa">
		<label>Altura</label>
		<input type="text" name="altura">
		<input type="submit">
		</form>
		<p> <!-- o PHP sempre tem que estar dentro de uma tag do HTML -->
			<?php
			$massa = $_POST['massa'];
			$altura = $_POST['altura'];
			$resultado = $massa/($altura*$altura);
			if($resultado!=0) //só mostra a resposta ao realizar a operacao
			{
				echo "Seu IMC é: ",round($resultado,2),"<br>"; //com aspas duplas a maneira de definir a variavel, funciona!
				if($resultado<18.5)
					echo 'Seco, desnutrido';
				elseif($resultado<25) //elseif funciona como se tivesse um break embutido nele caso seja verdadeiro o teste
					echo 'Morra!!! mocreia!!!';
				elseif($resultado<30)
					echo 'Recem casado';
				elseif($resultado<35)
					echo 'Geleia';
				elseif($resultado<40)
					echo 'Darci Pacheco';
				else
					echo 'Zi fudel';
			}
			?>
		</p>
		</body>
</html>