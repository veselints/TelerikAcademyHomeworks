/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
	return function (students) {
		var studentWithBestMarks = _.chain(students)
			.forEach(function(student) {
				var i,
					len = student.marks.length,
					averageMark = 0;

				for (i = 0; i < len; i++) {
					averageMark += student.marks[i];
				}

				student.averageMark = averageMark / len;
			})
			.sortBy(function(student) {
				return student.averageMark;
			})
			.last()
			.value();

		console.log(studentWithBestMarks.firstName + ' ' +
			studentWithBestMarks.lastName +
			' has an average score of ' +
			studentWithBestMarks.averageMark);
	};
}

module.exports = solve;
