<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MAS.aspx.cs" Inherits="SpaceApp.Meteors" %>

<!DOCTYPE html>
<html lang="es">
    <head>
        <meta charset="utf-8"/>
        <title>M2 Stones</title>
        <link rel="stylesheet" href="demo.css" type="text/css" media="screen"/>
        <link rel="stylesheet" href="demo-print.css" type="text/css" media="print"/>
        <script src="raphael.js"></script>
        <script src="popup.js"></script>
        <script src="jquery.js"></script>
        <script src="analytics.js"></script>
        <script src="world.js"></script>
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
        <style>
        #holder
        {
            width:1000px;
            height:400px;
        }
        body
        {
            background-image:url(img/bg.jpg);
        }
        </style>
    </head>
    <body>    
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
    </body>
    <script src="js/classie.js"></script>
	<script src="js/borderMenu.js"></script>
</html>
