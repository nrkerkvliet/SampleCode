function validateForm() {
	document.getElementById("nameValid").innerHTML = "";
	document.getElementById("passValid").innerHTML = "";
	document.getElementById("results").innerHTML = "";
	
	var success = true;
	var pass = document.getElementById("password").value;
	var userName = document.getElementById("userEntry").value;
	
	
	if (userName == "") {
		document.getElementById("nameValid").innerHTML = "Full Name cannot be blank";
		success = false;
	}
	
	if (pass == "") {
		document.getElementById("passValid").innerHTML = "Password cannot be blank";
		success = false;
	}
	

	if (success==true) {
		var results = "User Name:  " + userName + "<br>" + "Password:  " + pass + "<br>";
		document.getElementById("results").innerHTML = results;
		return true;
	}
	return false;
}