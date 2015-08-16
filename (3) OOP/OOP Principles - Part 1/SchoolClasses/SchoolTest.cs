// We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines.
// Students have name and unique class number. Classes have unique text identifier. Teachers have name.
// Disciplines have name, number of lectures and number of exercises. Both teachers and students are people.
// Students, classes, teachers and disciplines could have optional comments (free text block).

// Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class SchoolTest
    {
        static void Main(string[] args)
        {
            Student Pesho = new Student("Pesho Konstancaliev", 24, "stupid!");
            Student Lacho = new Student("Lachezar Petrov", 2, "verry stupid!");
            Student Penka = new Student("Penka Grozdanova", 4, "not so stupid!");
            Student Evelina = new Student("Evelina Makedonska", 14, "stupid!");
            Student Evstati = new Student("Evstati Penev", 1, "verry stupid!");
            Student Drago = new Student("Drago Petrov", 11, "stupid!");
            Student Muncho = new Student("Muncho Gunchev", 13, "stupid!");

            Discipline Math = new Discipline("Math", 50, 50, "cool");
            Discipline Geography = new Discipline("Geography", 2, 4, "verry cool");
            Discipline Astronomy = new Discipline("Astronomy", 4, 10, "so-so");

            Teacher Tomov = new Teacher(new Discipline[] {Math, Geography}, "Pesho Tomov", "stupid!");
            Teacher Petrov = new Teacher(new Discipline[] { Astronomy, Geography }, "Harampi Petrov", "verry stupid!");
            Teacher Dragov = new Teacher(new Discipline[] { Math, Astronomy }, "Drago Dragov", "stupid!");
            Teacher Haralambev = new Teacher(new Discipline[] { Math, Geography }, "Mryshtio Haralambev", "stupid!");

            ClassOfStudents theCoolestClass = new ClassOfStudents(new Student[] { Pesho, Evelina, Evstati, Drago }, new Teacher[] { Dragov, Haralambev, Tomov }, "5b");
        }
    }
}
