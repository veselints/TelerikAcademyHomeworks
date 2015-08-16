// Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade.
// Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker.
// Define the proper constructors and properties for this hierarchy.
// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student ("Pesho", "Goshev", 3),
                new Student ("Ivan", "Ivanov", 2),
                new Student ("Pyrvan", "Ilianov", 4),
                new Student ("Strahil", "Borisov", 5),
                new Student ("Momchil", "Sradlikov", 2),
                new Student ("Viktor", "Zebarski", 2),
                new Student ("Evstati", "Vasilev", 6),
                new Student ("Tryncho", "Snegoqdov", 2),
                new Student ("Gosho", "Pyrshivski", 3),
                new Student ("Slavqn", "Ebrehamov", 2)
            };

            var sortedStudents =
                from students in listOfStudents
                orderby students.Grade, students.FirstName, students.LastName
                select students;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            List<Worker> listOfWorkers = new List<Worker>
            {
                new Worker ("Marin", "Petrov", 245.34m, 6),
                new Worker ("Bakal", "Ivanov", 235.34m, 7),
                new Worker ("Sportal", "Iliev", 345.34m, 4),
                new Worker ("Pyrvan", "Todorov", 445.34m, 5),
                new Worker ("Evlampi", "Tsvetanov", 145.34m, 8),
                new Worker ("Eniu", "Zagorski", 245.44m, 8),
                new Worker ("Emanuel", "Evlampiev", 245.22m, 6),
                new Worker ("Preslav", "Snegoqdov", 220.14m, 7),
                new Worker ("Telerik", "Srednogorski", 245.00m, 3),
                new Worker ("Slavcho", "Ebrehamov", 225.54m, 3)
            };

            var sortedWorkers =
                from workers in listOfWorkers
                orderby workers.MoneyPerHour() descending, workers.FirstName, workers.LastName
                select workers;

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();


            List<Human> merged = new List<Human> { };
            foreach (var student in listOfStudents)
            {
                merged.Add(student);
            }
            foreach (var worker in listOfWorkers)
            {
                merged.Add(worker);
            }

            var sortedHumans =
                from humans in merged
                orderby humans.FirstName, humans.LastName
                select humans;

            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
