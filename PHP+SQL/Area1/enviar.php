<html> 
<head>
<body>
<form id="form1" name="form1" enctype="multipart/form-data" method="post" action="upload.php?codigo=<?php echo $_GET['codigo'];?>">
<label>
<input type="file" name="arquivo" id="filefield" />
</label>
<label>
<input type="submit" name="button" id="button" value="submit"/>
</label>
</form>
</body>
</html>