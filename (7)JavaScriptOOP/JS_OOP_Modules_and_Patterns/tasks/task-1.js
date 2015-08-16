/*jslint white: true */
/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
	var Course = {
		init: function(title, presentations) {
			if (validateTitle(title) && validatePresentationsArray(presentations)) {
				this.title = title;
				this.presentations = presentations;
				this.students;

				return this;
			}

			throw new Error('Invalid input!');
		},

		addStudent: function(name) {
			var student,
				nameArray,
				fName,
				lName,
				studentID;

			if (validateStudentName(name)) {
				if (!this.students) {
					this.students = [];
				}

				nameArray = name.split(' ');
				fName = nameArray[0];
				lName = nameArray[1];
				studentID = this.students.length + 1;

				

				student = {firstname: fName, lastname: lName, id: studentID};
				this.students.push(student);

				return this.students.length;
			} else {
				throw new Error('Invalid name input!');
			}
		},

		getAllStudents: function() {
			var result = [];

			if (this.students) {
				return this.students.slice(0);
			}

			return result;
		},

		submitHomework: function(studentID, homeworkID) {
			var currentStudent,
				i,
				len,
				self = this,
				homeworkAlreadySubmitted = false;

			if (validateStudentId(studentID, self) && validateHomeworkID(homeworkID, self)) {
				currentStudent = self.students[studentID - 1];
				if (!currentStudent.homeworks) {
					currentStudent.homeworks = [homeworkID];
				} else {
					len = currentStudent.homeworks.length;
					for (i = 0; i < len; i++) {
						if (currentStudent.homeworks[i] === homeworkID) {
							homeworkAlreadySubmitted = true;
							break;
						}
					}

					if (!homeworkAlreadySubmitted) {
						currentStudent.homeworks.push(homeworkID);
					}
				}
				return this;
			}

			throw new Error('You have given invalid ID input!');
		},

		pushExamResults: function(results) {
			var currentStudent,
				currentResult,
				j,
				i,
				len,
				lenOfResults,
				listed;

			if (validateResultsArray(results) && this.students) {
				len = this.students.length;
				for (i = 0; i < len; i++) {
					currentStudent = this.students[i];
					if (!validateStudentId(currentStudent)) {
						throw new Error('You have given invalid student ID!');
					}

					listed = false;

					lenOfResults = results.length;
					for (j = 0; j < lenOfResults; j++) {
						currentResult = results[j];
						if (currentStudent.id === currentResult.StudentID) {
							if (!currentStudent.result) {
								currentStudent.result = currentResult.Score;
								listed = true;
							} else {
								throw new Error('You try to give two scores to the same student!');
							}
						}
					}

					if (!listed) {
						currentStudent.result = 0;
					}
				}
			} else {
				throw new Error('There are no students subscribed to this course!');
			}
		},

		getTopStudents: function() {
			var result,
				i,
				len;

			len = this.students.length;

			for (i = 0; i < len; i++) {
				this.students[i].finalResult =
					(75 * this.students[i].result) +
					(25 * this.students[i].homeworks.length / this.presentations.length);
			}

			this.students.sort(function(a,b) {
				return a.finalResult - b.finalResult;
			});

			this.students.reverse();

			if (len <= 10) {
				return this.students;
			}

			result = [];
			for (i = 0; i < 10; i++) {
				result.push(this.students[i]);
			}
			return result;
		}
	};

	function validateTitle(title) {
		if (!((typeof title === 'string' || title instanceof String) && title)) {
			return false;
		}

		if (title[0].match(/\s/) || title[title.length - 1].match(/\s/)) {
			return false;
		}

		if (title.match(/\s+\s/)) {
			return false;
		}

		return true;
	}

	function validatePresentationsArray(presentations) {
		var i,
			len;
		
		if (vlidateArray(presentations)) {
			len = presentations.length;
			for (i = 0; i < len; i++) {
				if (!validateTitle(presentations[i])) {
					return false;
				}
			}

			return true;
		}

		return false;
	}

	function vlidateArray(obj) {
		if (obj instanceof Array && obj && obj.length > 0) {
			return true;
		}

		return false;
	}

	function validateStudentName(name) {
		var splittedName;

		if (!((typeof name === 'string' || name instanceof String) && name)) {
			return false;
		}

		splittedName = name.split(' ');
		if (splittedName.length !== 2) {
			return false;
		}

		if (splittedName[0].match(/[^A-z]/) || splittedName[1].match(/[^A-z]/)) {
			return false;
		}

		if (splittedName[0][0].match(/[^A-Z]/) || splittedName[1][0].match(/[^A-Z]/)) {
			return false;
		}

		if (!containsOnlyLowerCases(splittedName[0]) || !containsOnlyLowerCases(splittedName[1])) {
			return false;
		}

		return true;
	}

	function containsOnlyLowerCases(str) {
		var i,
			len;

		len = str.length;
		for (i = 1; i < len; i++) {
			if (str[i].match(/[^a-z]/)) {
				return false;
			}
		}

		return true;
	}

	function validateStudentId(studentId, self) {
		if (studentId <= self.students.length && studentId > 0) {
			return true;
		}

		return false;
	}
	
	function validateHomeworkID(homeworkId, self) {
		if (homeworkId <= self.presentations.length && homeworkId > 0) {
			return true;
		}

		return false;
	}

	function validateResultsArray(results) {
		var i,
			len;
		
		if (vlidateArray(results)) {
			len = results.length;
			for (i = 0; i < len; i++) {
				if(!results[i].StudentID || !results[i].Score) {
					return false;
				}

				if (typeof results[i].Score !== 'number') {
					return false;
				}
			}

			return true;
		}

		return false;
	}

	return Course;
}


module.exports = solve;

// var id, jsoop = Object.create(Course);
// 				jsoop.init('AlaBala', ['Alabala']);
// 				id = jsoop.addStudent('Pesho' + ' ' + 'Goshev');
// 				console.log(jsoop.students.length);
// 				jsoop.submitHomework(id, 1);