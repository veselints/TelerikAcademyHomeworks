using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Student : People
    {
        private int studentNumber;

        public int StudentNumber
        {
            get { return this.studentNumber; }
            private set
            {
                try
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("The student number should be a positive integer nember!");
                    }
                    else
                    {
                        this.studentNumber = value;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public Student(string name, int studentNumber)
        {
            Name = name;
            this.StudentNumber = studentNumber;
        }

        public Student(string name, int studentNumber, string comment)
            : this (name, studentNumber)
        {
            this.Comment = comment;
        }
    }
}
