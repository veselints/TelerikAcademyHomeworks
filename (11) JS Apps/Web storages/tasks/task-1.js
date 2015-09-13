// function solve() {
	var highScore = [];
	var abcd;
	var currentPlayerTurns;
	var rams = 0;

  	var generateRandom = function() {
		var randomNumber = Math.floor(Math.random() * 10);
		return randomNumber;
	};

	var updateHighscore = function(playerName, currentPlayerTurns) {
		highScore.push({name: playerName, score: currentPlayerTurns});
	};

	function init(playerName, endCallback) {
		var i, len = 3;
		currentPlayerTurns = 0;
		abcd = 1 + Math.floor(Math.random() * 9);

		for (i = 0; i < len; i++) {
			abcd = abcd.toString() + generateRandom().toString();
		}

		while (rams < 4) {
			guess(number);
		}

		updateHighscore(playerName, currentPlayerTurns);
		endCallback();
  	}

  	function guess(number) {
  		var result;
  		rams = 0;
  		var sheep = 0;
  		var i, j, k;
  		var len = 4;
  		var positionOfRams = [];
  		var ramAlready;

  		if (!abcd) {
  			throw new Error();
  		}

  		currentPlayerTurns += 1;

  		for (i = 0; i < len; i++) {
  			if (number[i] === abcd[i]) {
  				rams += 1;
  				positionOfRams.push(i);
  			}
  		}

  		for (i = 0; i < len; i++) {
  			ramAlready = false;
  			for (l = 0; l < positionOfRams.length; l++) {
  				if (positionOfRams[l] === i) {
  					ramAlready = true;
  					break;
  				}
  			}
  			if (ramAlready) {
  				continue;
  			}

  			for (j = 0; j < len - 1; j++) {
  				if ((i + 1 + j) === 4) {
  					k = 0;
  				} else {
  					k = i + 1 + j;
  				}
  				for (l = 0; l < positionOfRams.length; l++) {
	  				if (positionOfRams[l] === k) {
	  					ramAlready = true;
	  					break;
	  				}
	  			}
	  			if (ramAlready) {
	  				continue;
	  			}
  				if (number[i] === abcd[k]) {
  					sheep += 1;
  				}
  			}
  		}
  		
  		result = { sheep: sheep, rams: rams };

  		return result;
  	}

  	function getHighScore(count) {
  		var lenToBeReturned;
  		var orderedHighscore;
  		var returnedhighscore = [];
  		var i;

  		if (count < highScore.length) {
  			lenToBeReturned = count;
  		} else {
  			lenToBeReturned = highScore.length;
  		}

  		orderedHighscore = highScore.sort().reverse();

  		for (i = 0; i < lenToBeReturned; i++) {
  			returnedhighscore.push(highScore[i]);
  		}

  		return returnedhighscore;
  	}

  	// return {
   //  	init: init, 
   //  	guess: guess, 
   //  	getHighScore: getHighScore
  	// };
// }
	
	for (var i = 0; i < 25; i++) {
		var abcd = init();
		var number = (Number(init()) + 7).toString();
		console.log(abcd);
		console.log(number);

		console.log(guess(abcd, number));
	}


// module.exports = solve;
