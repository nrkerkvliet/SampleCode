<h2>
<?php

//setup connection variables at top of code to make it easy to change them
$hostName = "localhost:8000";
$userName = "root";
$password = "";
$databaseName = "test";
$tableName = "kern_table1";


$mysqli = new mysqli($hostName, $userName, $password, $databaseName );

if ($mysqli->connect_error) {
    die("<h2>Connect Error to $hostName: "
            . $mysqli->connect_error . "</h2>");
}

print("<hr />");
	
$query = 'SELECT * FROM ' . $tableName; //Create a SQL statement string

if(!$result = $mysqli->query($query)){
    die('There was an error running the query [' . $mysqli->error . ']');
}

//Display all rows / contents of $result object returned by query using fetch_assoc() method
while($row = $result->fetch_assoc()){
    print( $row["id"] . " " . $row["firstName"] . " " . $row["lastName"] . " " . $row["phoneNumber"]
 . "<br />");
}

$mysqli->close();
?>
</h2>
