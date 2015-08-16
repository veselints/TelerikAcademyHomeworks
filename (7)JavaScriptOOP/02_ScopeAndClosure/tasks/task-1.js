/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		var i;
		var len;
		var existingCategory;
		var result;

		function listBooks(obj) {
			if (arguments.length > 0) {
				result = [];
				for (i = 0, len = books.length; i < len; i++) {
					if (obj.category && obj.category === books[i].category) {
						result.push(books[i]);
					}
					if (obj.author && obj.author === books[i].author) {
						result.push(books[i]);
					}
				}
				return result;
			}
			return books;
		};

		function addBook(book) {
			validateBookTitle(book.title);
			validateBookCategory(book.category);
			validateBookAuthor(book.author);
			validateBookIsbn(book.isbn);

			book.ID = books.length + 1;
			books.push(book);

			existingCategory = false;
			for (i = 0, len = categories.length; i < len; i++) {
				if (categories[i] === book.category) {
					existingCategory = true;
					break;
				}
			}

			if (!existingCategory) {
				categories.push(book.category);
			}

			return book;
		};

		function validateBookTitle(title) {
			if (typeof(title) !== 'string' || title.length < 2 || title.length > 100){
				throw new Error('Invalid title!');
			}
			for (i = 0, len = books.length; i < len; i++) {
				if (title === books[i].title) {
					throw new Error('You have entered an already existing book!');
				}
			}
		};
		function validateBookCategory(category) {
			if (typeof(category) !== 'string' || category.length < 2 || category.length > 100){
				throw new Error('Invalid category!');
			}
		};
		function validateBookAuthor(author) {
			if (typeof(author) !== 'string' || author.length < 1){
				throw new Error('Invalid author!');
			}
		};
		function validateBookIsbn(isbn) {
			if (!(isbn.length === 10 || isbn.length === 13)) {
				throw new Error('You have entered invalid ISBN!');
			}
			for (i = 0, len = isbn.length; i < len; i++) {
				if ((isNaN(parseInt(isbn[i])))) {					
					throw new Error('You have entered invalid ISBN!');
				}
			}
			for (i = 0, len = books.length; i < len; i++) {
				if (isbn === books[i].isbn) {
					throw new Error('You have entered an already existing ISBN!');
				}
			}
		};

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
