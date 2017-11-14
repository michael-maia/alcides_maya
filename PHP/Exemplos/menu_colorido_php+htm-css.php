<!DOCTYPE html>
<html lang='pt-br'>
	<head>
		<meta charset='utf-8'>
		<style>
		.menu_item
		{
			background-color:#f1f1f1;
			list-style:none;
			width:100px;
		}
		.selected
		{
			background-color:#4caf50;
		}
		</style>
	</head>
	<body>
		<ul>
			<!-- deve-se usar "?" no href para que ele entenda que ali termina o nome do arquivo no link -->
			<!-- o "?item" faz parte do método GET -->
			<li class="menu_item <?php if($_GET['item']=='home'){echo 'selected';}?>"> <a href="?item=home">Home</a></li>
			<li class="menu_item <?php if($_GET['item']=='produtos'){echo 'selected';}?>"> <a href="?item=produtos">Produtos</a></li>
			<li class="menu_item <?php if($_GET['item']=='servicos'){echo 'selected';}?>"> <a href="?item=servicos">Serviços</a></li>
			<li class="menu_item <?php if($_GET['item']=='sobre'){echo 'selected';}?>"> <a href="?item=sobre">Sobre</a></li>
			<li class="menu_item <?php if($_GET['item']=='contato'){echo 'selected';}?>"> <a href="?item=contato">Contato</a></li>
			
			<!-- há possibilidade de usar 2 classes ao mesmo tempo em uma tag
				só é necessário separar os nomes usando espaço -->
		</ul>		
	</body>
</html>	
		
		
	