<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NEA.aspx.cs" Inherits="SpaceApp.NEA" %>

<!DOCTYPE html>
<html lang="es">
    <head>
        <meta charset="utf-8"/>	
        <title>M2 Stones</title>
        <link rel="stylesheet" href="demo.css" type="text/css" media="screen"/>
        <link rel="stylesheet" href="demo-print.css" type="text/css" media="print"/>
        <script type='text/javascript' src='jquery-2.1.0.js'></script>
		<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"> 
		<meta name="viewport" content="width=device-width, initial-scale=1.0"/> 
		<meta name="description" content="Asteroids" />
		<meta name="keywords" content="steroids, spaceapps, nasa" />
		<meta name="author" content="M2" />
		<link rel="shortcut icon" href="../favicon.ico"/>
		<link rel="stylesheet" type="text/css" href="css/normalize.css" />
		<link rel="stylesheet" type="text/css" href="css/demo2.css" />
		<link rel="stylesheet" type="text/css" href="css/icons.css" />
		<link rel="stylesheet" type="text/css" href="css/style3.css" />
		<script src="js/modernizr.custom.js"></script>
    
	<script type="text/javascript">
	    function siguiente() {

	        var valueselected = parseInt($("#navigation").val());
	        resetElement(valueselected);
	        valueselected++;
	        if (valueselected > parseInt($("#allcount").val())) {
	        }
	        else {
	            $("#navigation").val(valueselected);
	            $('#Foto' + valueselected).animate({
	                'left': '-800px',
	                'top': '-50px',
	                'display': 'block'
	            }, 0).animate({
	                'left': '40px',
	                'width': '250px',
	                'height': '250px',
	                'top': '150px'
	            }, 1500);

	            $('#Descripcion' + valueselected).animate({
	                'left': '300px',
	                'top': '150px'
	            }, 2000);
	        }
	    }

	    function anterior() {
	        var valueselected = parseInt($("#navigation").val());
	        resetElement(valueselected);
	        valueselected--;
	        if (valueselected < 0) {
	        }
	        else {
	            $("#navigation").val(valueselected);
	            $('#Foto' + valueselected).animate({
	                'left': '-800px',
	                'top': '-50px',
	                'display': 'block'
	            }, 0).animate({
	                'left': '80px',
	                'width': '250px',
	                'height': '250px',
	                'top': '150px'
	            }, 1500);

	            $('#Descripcion' + valueselected).animate({
	                'left': '300px',
	                'top': '150px'
	            }, 2000);
	        }
	    }

	    function resetElement(identi) {
	        if (identi > 0 && identi <= parseInt($("#allcount").val())) {
	            $('#Foto' + identi).animate({
	                'left': '-2000px',
	                'top': '100px',
	                'width': '2000px',
	                'height': '2000px',
	                'display': 'none'
	            }, 0);

	            $('#Descripcion' + identi).animate({
	                'left': '-700px'
	            }, 0);
	        }
	    }
    </script>
	<style>          
	.cajafuera{
		left:-700px;	
		position:absolute;  
	}     
	.cajafoto{
		left:-2000px;
		top:100px;	
		position:absolute;  
		display:none;
	}
	
	.descripcion h1
	{
		font-family:"Arial Black", Gadget, sans-serif;
		text-transform:uppercase;
		font-size: 32px;
		text-shadow:-1px -1px #124381, 1px 1px #333;
	}
	.descripcion
	{
		font-size: 16px;
		font-weight: bold;
		color: #ddd;
		top:500px;
		background: rgba(255,255,255,0.1);
		width: 400px;
		margin: 0;
		border-radius: 10px;
		border: 1px solid rgba(255,255,255,0.2);
		padding:0px 20px 20px 40px;
	}
	.descripcion td
	{
		padding-left:10px;
		
	}
	.descripcion span
	{
		font-family: Arial, Helvetica, sans-serif;
		font-size:25px;
	}
	.red{color:#75d0ff}
	.green{color:#ff7575}
	.blue{color:#fff075}
	#earth a{
		font-size:60px;
		font-family:"Trebuchet MS", Arial, Helvetica, sans-serif;
		font-weight:bolder;	
		text-decoration:none;
		color:#CCC;
		background: rgba(255,255,255,0.1);
		padding: 5px 5px 5px 5px;
		border-radius: 10px;
		border: 1px solid rgba(255,255,255,0.2);
	}
	body {
    background: #222222;
    color: #fff;
    font: 300 100.1% "Helvetica Neue", Helvetica, "Arial Unicode MS", Arial, sans-serif;
	min-height:600px;
	min-width:1000px;
	 background-image:url(img/bg.jpg);
    }
    </style>
    </head>
    <div class="container">
			<header class="codrops-header">
                               			
			</header>
			<nav id="bt-menu" class="bt-menu">
				<a href="#" class="bt-menu-trigger"><span>Menu</span></a>
				<ul>
					<li><a href="Meteors.aspx" class="bt-icon icon-user-outline">Impactos</a></li>
					<li><a href="NEA.aspx" class="bt-icon icon-sun">NEA</a></li>
					<li><a href="PHA.aspx" class="bt-icon icon-windows">PHA</a></li>
					<li><a href="Social.aspx" class="bt-icon icon-speaker">Reporta</a></li>
					<li><a href="MAS.aspx" class="bt-icon icon-star">Mas</a></li>
                    <li><a href="https://2014.spaceappschallenge.org/" class="bt-icon icon-star">SpaceApps</a></li>
				</ul>
			</nav>              
		</div>
        <div  style="position:relative; top:-30px; left:900px; width:100px;">
        <img id="photo" src="img/tierra.png" width="300" height="300"/>
       </div>
          <div id="earth" style="width:300px; margin-left:auto; padding-left:25px; margin-right:auto; margin-top:100px;">
            <a href="javascript:anterior();" id="izquierda">◄</a>
            <a href="javascript:siguiente();" id="derecha" style="margin-left:100px;">►</a>
          <div>

          <% Response.Write(getMeteorsHtmlTable()); %>
         
        <input type="hidden" id="navigation" name="navigation" value="0"/>
        <input type="hidden" id="allcount" name="allcount" value="10"/>     
    </body>
    <script src="js/classie.js"></script>
	<script src="js/borderMenu.js"></script>
</html>
