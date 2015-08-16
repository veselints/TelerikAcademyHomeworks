using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class ClassOfStudents : Commentable
    {
        private Student[] classStudents;
        private Teacher[] classTeachers;
        private string classIdentifier;

        public Student[] ClassStudents
        {
            get { return this.classStudents; }
            private set
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("You have not entered any students!");
                }
                else
                {
                    this.classStudents = new Student[value.Length];
                    for (int i = 0; i < value.Length; i++)
			        {
			            this.classStudents[i] = value[i];
			        }  
                }
            }
        }

        public Teacher[] ClassTeachers
        {
            get { return this.classTeachers; }
            private set
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("You have not entered any teachers!");
                }
                else
                {
                    this.classTeachers = new Teacher[value.Length];
                    for (int i = 0; i < value.Length; i++)
                    {
                        this.classTeachers[i] = value[i];
                    }
                }
            }
        }

        public string ClassIdentifier
        {
            get { return this.classIdentifier; }
            private set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("The class identifier should be at least two symbols!");
                }
                else
                {
                    this.classIdentifier = value;
                }
            }
        }

        public ClassOfStudents(Student[] students, Teacher[] teachers, string identifier)
        {
            this.ClassStudents = students;
            this.ClassTeachers = teachers;
            this.ClassIdentifier = identifier;
        }

        public ClassOfStudents(Student[] students, Teacher[] teachers, string identifier, string comment)
            : this (students, teachers, identifier)
        {
            this.Comment = comment;
        }
    }
}
