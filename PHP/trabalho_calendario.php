<!doctype html>
<html>
  <head>
  </head>
  <body>
    <form>
	  <label>DIA</label>
	  <input type='text' name='dia'><br><br>
	  <label>MÊS</label>
	  <input type='text' name='mes'><br><br>
	  <label>ANO</label>
	  <input type='text' name='ano'><br>
	  <input type='submit'><br><br>
	</form>
<?php
function linha($semana)
{
	echo "<tr>";
	for($i=0;$i<7;$i++)
	{
		if(isset($semana[$i])) 
			echo "<td>{$semana[$i]}</td>";
		else
			echo "<td></td>";
	}
	echo "</tr>";
}	 
function calendario()
{
	$semana = array();
	$dia = 2;
	$diaF=$_GET['dia']; //PARA CASO QUERER USAR A VARIAVEL $DIA
	$mesF=$_GET['mes'];
	$anoF=$_GET['ano'];
	$data=mktime(1,1,1,$mesF,1,$anoF);
	if($data==false)
		echo 'INFORMAÇÃO ERRADA';
	$first_day=date("l",$data); // esta variavel vai definir a partir da funcao mktime() em qual dia da semana é o primeiro dia do mês
	echo date("F",$data); //usar 'w' para pegar os dias da semana de 0-6 e mudar os cases no switch
	switch($first_day) // utilizando o resultado da variavel $first_day, podemos saber em qual posição vai o 1 na primeira linha
	{
		case 'Sunday': $semana[0]=1;break;
		case 'Monday': $semana[1]=1;break;
		case 'Tuesday': $semana[2]=1;break;
		case 'Wednesday': $semana[3]=1;break;
		case 'Thursday': $semana[4]=1;break;
		case 'Friday': $semana[5]=1;break;
		case 'Saturday': $semana[6]=1;break;
		default: echo 'ERROR';
	}
	while ( $dia<=31)
	{
		array_push($semana,$dia); 
		if(isset($semana[6])==true)
		{
			 linha($semana); //funcao linha() 
			 $semana = array(); //limpa o vetor $semana para adicionar novos valores
		}
		$dia++;
    }
	if(!$semana[6]==31)
		linha($semana);
}
?>	
		<table border = "1" style="border-collapse:collapse;"> <!-- aqui eh definido o cabecalho do calendário -->
			<tr>
				<td>DOM</td>
				<td>SEG</td>
				<td>TER</td>
				<td>QUA</td>
				<td>QUI</td>
				<td>SEX</td>
				<td>SAB</td>
			</tr>
<?php calendario(); ?>
		</table>
	</body>
</html>
