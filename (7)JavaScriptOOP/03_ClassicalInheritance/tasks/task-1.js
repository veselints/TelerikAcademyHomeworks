/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string in the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {

		Object.defineProperty(Person.prototype, 'fullname', {
			get: function() {
				return this.firstname + ' ' + this.lastname;
			},
			set: function(newNameValue) {
				var fullNameArray = newNameValue.split(' ');
				if (fullNameArray.length !== 2) {
					throw new Error('You have entered full name in invalid format!');
				}
				setFirstName(fullNameArray[0]);
				setLastName(fullNameArray[1]);
				return this;
			},
		});

		function Person(fName, lName, age) {
			var fn = fName + ' ' + lName;
			setFirstName(fName);
			setLastName(lName);
			setAge(age);
		}

		function setFirstName(fName) {
			validateName(fName);
			Person.prototype.firstname = fName;
		}

		function setLastName(lName) {
			validateName(lName);
			Person.prototype.lastname = lName;
		}

		function setAge(age) {
			age = parseInt(age);
			if (isNaN(age)) {
				throw new Error('You have entered age in invalid format!');
			}
			else if (age < 0 || age > 150) {
				throw new Error('You have entered invalid age!');
			}
			Person.prototype.age = age;
		}
		

		function validateName(name) {
			if (typeof(name) !== 'string') {
				throw new Error('You have entered name in invalid format!');
			}
			else if (name.length < 3 || name.length > 20) {
				throw new Error('You have entered name with invalid number of characters!');
			}
			return true;
		}

		Person.prototype.introduce = function() {
			return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
		}

		return Person;
	} ());
	return Person;
}
module.exports = solve;