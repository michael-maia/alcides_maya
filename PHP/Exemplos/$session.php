<?php session_start(); ?>
<!doctype html>
<html>
	<head>		
	</head>
	<body>
		<form>
			<fieldset>
				<legend>Nova Tarefa</legend>
				<label> Tarefa <input name="nome"></label>
				<input type="submit">
			</fieldset>
		</form>
		<h2>Tarefas</h2>
		<ul>
		<?php
			if(isset($_GET['nome'])): //evita que o primeiro li seja uma bolinha vazia
				$_SESSION['lista_tarefas'][]=$_GET['nome'];
				foreach($_SESSION['lista_tarefas'] as $item):	//laço foreach percorre o vetor do começo ao fim 
				echo "<li>";
				echo $item;
				echo "</li>";
				endforeach;		//abrir a função : e colocar endforeach
				endif;
		?>
		</ul>
	</body>