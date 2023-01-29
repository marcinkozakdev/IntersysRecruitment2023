function optionalPow(a,b) {
	let result
	var userInput = confirm("Question?")
	if (userInput === true) {
		result = Math.pow(a,b)
		console.log(result);
		alert("Result: " + result)
	}
	if(userInput === false) {
		result = Math.pow(b,a)
		console.log(result);
		alert("Result: " + result)
	}
}
