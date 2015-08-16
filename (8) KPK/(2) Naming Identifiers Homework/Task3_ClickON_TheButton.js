function alertIfcurrentAppCodeNameIsMozilla(event, args) {
	var currentWindow = window,
    	currentAppCodeName = currentWindow.navigator.appCodeName,
    	checkIfcurrentAppCodeNameIsMozilla = (currentAppCodeName == "Mozilla");

	if (checkIfcurrentAppCodeNameIsMozilla) {
    	alert("Yes");
	} else {
		alert("No");
	}
}