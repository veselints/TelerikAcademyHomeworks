/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  	return function (books) {
  		var mostPopularAuthor = [];
  		var currentAuthor;
  		var numberOfBooksOfTheMostPopularAuthor = 0;
  		var i, len;
  		var orderedMostPopular;

  		var booksGroupedByAuthor = _.groupBy(books, function(book) {
  			return (book.author.firstName + ' ' + book.author.lastName);
  		});

  		_.mapObject(booksGroupedByAuthor, function(val, key) {
  			if (booksGroupedByAuthor[key].length > numberOfBooksOfTheMostPopularAuthor) {
  				numberOfBooksOfTheMostPopularAuthor = booksGroupedByAuthor[key].length;
  				mostPopularAuthor = [key];
  			} else if (booksGroupedByAuthor[key].length == numberOfBooksOfTheMostPopularAuthor) {
  				mostPopularAuthor.push(key);
  			}
  		});

  		orderedMostPopular = mostPopularAuthor.sort();

  		_.forEach(orderedMostPopular, function(author) {
  			console.log(author);
  		});
  	};
}

module.exports = solve;
