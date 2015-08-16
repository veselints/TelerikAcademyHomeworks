using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1to3StudentClass.StudentProperties;
using _1to3StudentClass.StudentProperties.UniversityEnums;

namespace _1to3StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student test = new Student(
                new PersonalDetails("Pesho", "Adreev", "Palaveev", 8512152856),
                new Contacts("Sofia, j.k. \"Yavorov\", bl. 55, b", "0888 53 63 63", "kreten@gmail.com"),
                new UniversityInfo(5, Specialty.CivilEngeneering, University.UACEG, Faculty.Engeneering)
                );

            Console.WriteLine(test);

            Student test2 = new Student(
                new PersonalDetails("Pesho", "Adreev", "Palaveev", 8512152856),
                new Contacts("Sofia, j.k. \"Yavorov\", bl. 55, b", "0888 53 63 63", "kreten@gmail.com"),
                new UniversityInfo(5, Specialty.CivilEngeneering, University.UACEG, Faculty.Engeneering)
                );

            Console.WriteLine(test == test2);

            Console.WriteLine(test != test2);

            Console.WriteLine(test.Equals(test2));

            Console.WriteLine(test.GetHashCode());

            Student test3 = test.Clone();

            Console.WriteLine(test3);

            Console.WriteLine();


            Student compareTest1 = new Student(
                new PersonalDetails("Pesho", "Adreev", "Palaveev", 8812152856),
                new Contacts("Sofia, j.k. \"Yavorov\", bl. 55, b", "0888 53 63 63", "kreten@gmail.com"),
                new UniversityInfo(5, Specialty.CivilEngeneering, University.UACEG, Faculty.Engeneering)
                );

            Student compareTest2 = new Student(
                new PersonalDetails("Pesho", "Adreev", "Ivanov", 8812152856),
                new Contacts("Sofia, j.k. \"Yavorov\", bl. 55, b", "0888 53 63 63", "kreten@gmail.com"),
                new UniversityInfo(5, Specialty.CivilEngeneering, University.UACEG, Faculty.Engeneering)
                );

            Student compareTest3 = new Student(
                new PersonalDetails("Pesho", "Petrov", "Ivanov", 8812152856),
                new Contacts("Sofia, j.k. \"Yavorov\", bl. 55, b", "0888 53 63 63", "kreten@gmail.com"),
                new UniversityInfo(5, Specialty.CivilEngeneering, University.UACEG, Faculty.Engeneering)
                );

            Student compareTest4 = new Student(
                new PersonalDetails("Evstati", "Petrov", "Ivanov", 8812152856),
                new Contacts("Sofia, j.k. \"Yavorov\", bl. 55, b", "0888 53 63 63", "kreten@gmail.com"),
                new UniversityInfo(5, Specialty.CivilEngeneering, University.UACEG, Faculty.Engeneering)
                );

            var initialList = new List<Student>{test, compareTest1, compareTest2, compareTest3, compareTest4};

            initialList.Sort();

            foreach (var student in initialList)
	        {
		         Console.WriteLine(student);
                 Console.WriteLine();
	        }
        }
    }
}
