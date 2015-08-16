// Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
// Use LINQ query operators.

// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
// Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems3to5
{
    class TestStudents
    {
        public static IEnumerable<Student> FirstNameBeforeLast(Student[] inputArray)
        {
            IEnumerable<Student> result =
                from student in inputArray
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return result;
        }

        public static IEnumerable<Student> AgeBetween18and24(Student[] inputArray)
        {
            IEnumerable<Student> result =
                from student in inputArray
                where student.Age >= 18 && student.Age <= 24
                select student;
            return result;
        }

        public static IEnumerable<Student> OrderedListOfStudents(Student[] inputArray)
        {
            
            
            IEnumerable<Student> result =
                from student in inputArray
                orderby student.FirstName, student.LastName
                select student;
            return result;
        }

        public static IEnumerable<Student> OrderedListOfStudentsLinq(Student[] inputArray)
        {


            IEnumerable<Student> result = inputArray.OrderBy(student => student.FirstName)
                                                    .ThenBy(student => student.LastName);
            return result;
        }
        
        static void Main(string[] args)
        {
            Student[] studentsArray =
            {
                new Student("Ivan", "Petrov", 12),
                new Student("Atanas", "Georgiev", 22),
                new Student("Georgi", "Atanassov", 50),
                new Student("Stamat", "Dimitrov", 19),
                new Student("Pesho", "Todorov", 27),
                new Student("Pesho", "Ivanov", 27),
                new Student("Pesho", "Peshev", 27),
                new Student("Pesho", "Andreev", 27)
            };

            IEnumerable<Student> firstNameBeforeLast = FirstNameBeforeLast(studentsArray);
            foreach (var student in firstNameBeforeLast)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            IEnumerable<Student> between18and24 = AgeBetween18and24(studentsArray);
            foreach (var student in between18and24)
            {;
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();

            IEnumerable<Student> odered = OrderedListOfStudents(studentsArray);
            foreach (var student in odered)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            IEnumerable<Student> oderedLinq = OrderedListOfStudentsLinq(studentsArray);
            foreach (var student in oderedLinq)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
