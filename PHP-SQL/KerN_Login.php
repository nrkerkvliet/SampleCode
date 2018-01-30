<h2>
<?php
$proceed=false;
//setup connection variables at top of code to make it easy to change them
$hostName = "localhost";
$userName = "";
$password = '';
$databaseName = "id2734117_test";
$tableName = "kern_login";

$mysqli = new mysqli($hostName, $userName, $password, $databaseName );

if ($mysqli->connect_error) {
    die("<h2>Connect Error to $hostName: "
            . $mysqli->connect_error . "</h2>");
}

if (isset($_POST['userEntry']) && isset($_POST['password'])) {
	$userQuery = $_POST['userEntry'];
	$passQuery = $_POST['password'];
}
else {
	die('UserField and password cannot be blank');
}
	
	
$query = "SELECT * FROM kern_login WHERE kern_login.user='" . $userQuery. "'"; //Create a SQL statement string
$result = $mysqli->query($query);

if(!$result = $mysqli->query($query)){
    die('There was an error running the query [' . $mysqli->error . ']');
}

print("query \"$query\" successful!<br /><br />");
//Display all rows / contents of $result object returned by query using fetch_assoc() method
if ($result->num_rows==0) {
    print('Invalid login credentials');
	print("<br>");
	print('<a href="http://nrkerkvliet.000webhostapp.com/KerN_Apache1/KerN_Unit4_Ex3/KerN_Registration.html">Click here to return</a>');
}

while($row = $result->fetch_assoc()){
		if($userQuery==$row["user"] && $passQuery==$row["password"]) {
			$proceed=true;
			if($row["securityLevel"]=="Admin") {
				print("<hr />");
				print('Admin login recognized');
				print("<br>");
				$query = "SELECT * FROM kern_login";
				$result = $mysqli->query($query);
				while($row = $result->fetch_assoc()){
					   print( $row["user"] . " " . $row["password"] . " " . $row["securityLevel"] . " " . $row["userID"]
					. "<br />");
				}
			}
		}
}

$mysqli->close();
if($proceed==true) {
	include 'KerN_Display_Table.php';
}
?>
</h2>