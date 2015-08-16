// Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
// Create a List<Student> with sample students. Select only the students that are from group number 2.
// Use LINQ query. Order the students by FirstName.

// Implement the previous using the same query expressed with extension methods.

// Extract all students that have email in abv.bg.
// Use string methods and LINQ.

// Extract all students with phones in Sofia.
// Use LINQ.

// Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
// Use LINQ.

// Write down a similar program that extracts the students with exactly two marks "2".
// Use extension methods.

//Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

// Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
// Use LINQ.

// Rewrite the previous using extension methods.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems9to16
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> listOfStudents = new List<Student>
            {
                new Student ("Pesho", "Ivanov", 790806, "02 72 72 17", "damugo_hvryk@abv.bg", new List<int> {5, 2 ,3 , 4}, 5),
                new Student ("Petkan", "Pavlov", 723804, "032 72 22 27", "dagruhvryk@mail.bg", new List<int> {6, 2 ,4 , 2},  2),
                new Student ("Evstati", "Trybichev", 721801, "056 22 22 22", "dstavriryk@mail.bg", new List<int> { 6, 3, 4, 6 }, 4),
                new Student ("Stoyan", "Evlapiev", 310806, "04515 34 53 61", "hurko_mehurchev@abv.bg", new List<int> {2, 3 ,3 , 2}, 5),
                new Student ("Ivan", "Pavlov", 653805, "068 14 34 51", "dagruhvryk@mail.bg", new List<int> {6, 5 ,4 , 4},  2),
                new Student ("Hrumcho", "Angelov", 131806, "033 62 62 51", "dstavriryk@mail.bg", new List<int> {5, 3, 5, 6 }, 2),
                new Student ("Temenujka", "Kravarova", 232807, "066 25 17 27", "dhryn_mrynk@abv.bgg", new List<int> {5, 5 ,3 , 5}, 2),
                new Student ("Taralejka", "Elenova", 413805, "02 31 72 42", "dalabala@mail.bg", new List<int> {6, 6 ,4 , 4},  2),
                new Student ("Veselin", "Pavlov", 733306, "02 22 23 41", "tralala@mail.bg", new List<int> { 5, 2, 6, 6 }, 1),
            };

            Console.WriteLine("==== LINQ: =====");

            Console.WriteLine("Members of group 2:");

            var studentsInGroup2 =
                from student in listOfStudents
                where student.GroupNumber == 2
                select student;
            
            foreach (var student in studentsInGroup2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Ordered by name:"); 
            var orderedStudents =
                from student in listOfStudents
                orderby student.FirstName, student.LastName
                select student;

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("All that have Email in abv.bg:");
            var abvEmail =
                from student in listOfStudents
                where student.Email.Contains("@abv.bg")
                select student;

            foreach (var student in abvEmail)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("All that have telephone in Sofia:");
            var sofiaTell =
                from student in listOfStudents
                where student.Telephone.StartsWith("02 ")
                select student;

            foreach (var student in sofiaTell)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("All with exellent mark:");
            var studentsWithExcellent =
                from student in listOfStudents
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    MarksList = student.Marks
                };

            foreach (var student in studentsWithExcellent)
            {
                Console.Write(student.FullName); 
                foreach (var mark in student.MarksList)
	            {
		            Console.Write(mark);
                    Console.Write(" ");
	            }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Grouped by group number:");

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Students in group {0}:", i);
                var studentsInGroupI =
                from student in listOfStudents
                where student.GroupNumber == i
                select student;

                foreach (var student in studentsInGroupI)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("==== Extention methods: =====");

            Console.WriteLine("Members of group 2:"); 

            var studentsInGroup2Extention = listOfStudents.Where(x => x.GroupNumber == 2);

            foreach (var student in studentsInGroup2Extention)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Ordered by name:"); 
            var orderedStudentsExtentin = listOfStudents.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var student in orderedStudentsExtentin)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("With 2 marks \"2\":");
            var withTwo = listOfStudents.Where(x => x.Marks.Contains(2));
            foreach (var student in withTwo)
	        {
		         student.Marks.Remove(2);
	        }
            var withTwoTwos = withTwo.Where(x => x.Marks.Contains(2));

            foreach (var student in withTwoTwos)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Enrolled in 2006:");
            var enrolledIn2006 = listOfStudents.Where(x => x.FacultyNumber.ToString().EndsWith("06"));
            foreach (var student in enrolledIn2006)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Grouped by group number:");

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Students in group {0}:", i);
                var studentsInGroupI =listOfStudents.Where(x => x.GroupNumber == i);

                foreach (var student in studentsInGroupI)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine();
            }
        }
    }
}
