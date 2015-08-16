

function findPrimes(from, to) {
	var i,
		j,
		squareRoot,
		switchNumbers,
		isPrime,
		resultArray = [];
	from = parseInt(from);
	to = parseInt(to);
	if ((!from && from !== 0) || (!to && to !== 0)) {
		throw new Error('You have entered invalid arguments!');
	}
	if (from > to) {
		switchNumbers = from;
		from = to;
		to = switchNumbers;
	};

	for (i = from; i <= to; i += 1) {
		if (i === 0 || i === 1) {
			continue;
		}
		squareRoot = Math.sqrt(i) | 0;
		isPrime = true;
		debugger;
		for (j = 2; j <= squareRoot; j += 1) {
			if (!(i % j)) {
				isPrime	= false;
				break;
			}
		};
		if (isPrime) {
			resultArray.push(i);
		}
	}
	return resultArray;
}

console.log(findPrimes(1,5));