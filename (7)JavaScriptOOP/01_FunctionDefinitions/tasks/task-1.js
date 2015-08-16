/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(inputArr) {
	var len,
		i,
		sum,
		currentNumber;
	if (inputArr.length === 0) {
		return null;
	}
	else if (inputArr === undefined) {
		throw new Error('You didn\'t enter array');
		return;
	}
	len = inputArr.length;
	sum = 0;
	for (i = 0; i < len; i++) {
		currentNumber = parseInt(inputArr[i]);
		if (!currentNumber && currentNumber!== 0) {
			throw new Error('You have entered an argument that is not a number!');
			return;
		}
		sum += currentNumber;
	};
	return sum;
}

//sum([4, 5, 6,]);

module.exports = sum;
