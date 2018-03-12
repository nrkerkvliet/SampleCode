<!DOCTYPE>
<html>
	<head>
		<title>Arrays</title>
	</head>     
	<body>
	<h1>Arrays</h1>
	
	<?php
		$name=array('Nathan', 'Rober', 'Kerkvliet');
		echo $name[2];
		echo "<br>";
		$food=array('Pizza',10,15,array("Asian","French","German"),"Pasta");
		echo $food[2] . "<br>";
		echo $food[3][2] . "<br>";
		$food[56]="Mango";
		$food[300]="Apple";
		echo print_r($food) . "<br>";
		
		$Color=array("A"=>"40","B"=>"Pizza");
		echo $Color["A"] . "<br>";
		echo $Color["B"] . "<br>";
		
		echo "<hr>";
		$col=array("red","green","blue");
		array_pop($col);
		array_push($col, "black", "white", "pink");
		print_r($col);
		echo "<br>";
		$Numbers=array(13,54,6,89,100,15,12,789,1000);
		echo "Count:  " . count($Numbers) . "<br>";
		echo "Max:  " . max($Numbers) . "<br>";
		echo "Min:  " . min($Numbers) . "<br>";
		echo "Is 89 in array:  " . in_array(89, $Numbers) . "<br>";
		echo "Sort accomplish:  " . sort($Numbers) . "<br>";
		print_r($Numbers);
		echo "rSort accomplish: " . rsort($Numbers) . "<br>";
		print_r($Numbers);
		
		$Quote=array("Never","Give","UP","in","life");
		echo "Implode:  " . implode(" ",$Quote) . "<br>";
		$strQuote = "Never Give UP in life";
		echo "Explode: ";
		print_r(explode(" ",$strQuote));
		
	 ?> 
	 
</body>
</html>