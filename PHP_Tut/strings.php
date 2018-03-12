<!DOCTYPE>
<html>
	<head>
		<title>Strings</title>
	</head>     
	<body>
	<h1>Strings</h1>
	
	<?php
		echo " my name is Nathan Kerkvliet <br>";
		echo ' my age is 26 <br>';
		$color = "red";
		$shirt = "sleev-less";
		$combination = $color . " " . $shirt;
		echo $color;
		echo "<br>";
		echo $shirt . "<br>";
		echo $combination . "<br>";
		
		$phrase1="students who come late ";
		$phrase2="in class sit in last with Rock";
		$combine = $phrase1;
		$combine .= $phrase2;
		echo "Original full string: $combine <br>";
	 ?>
 Uppercase first: <?php echo ucfirst($combine); ?><br>
 Uppercase words: <?php echo ucwords($combine); ?><br>
 Lowercase: <?php echo strtolower($combine); ?><br>
 Uppercase: <?php echo strtoupper($combine); ?><br>
 Repeat: <?php echo str_repeat($combine, 3); ?><br>
 Substring: <?php echo substr($combine, 5, 10); ?><br>
 Search String: <?php echo strpos($combine, "come"); ?><br>
 Find char: <?php echo strchr($combine, "k"); ?> <br>
 String Length: <?php echo strlen($combine); ?><br>
 Trim: <?php echo "A" . trim(" B C D ") . "E"; ?><br>
 Find specific and show after: <?php echo strstr($combine, "come"); ?><br>
 Replace word with new: <?php echo str_replace("sit", "stand", $combine); ?><br>
	 
</body>
</html>