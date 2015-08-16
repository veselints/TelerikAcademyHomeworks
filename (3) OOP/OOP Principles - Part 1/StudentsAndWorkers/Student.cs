using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                try
                {
                    if (value < 2 || value > 6)
                    {
                        Console.WriteLine("The grade must be an integer between 2 and 6!");
                    }
                    else
                    {
                        this.grade = value;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public Student(string firstName, string lastName, int grade)
         : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return String.Format(this.FirstName + " " + this.LastName + " " + this.Grade);
        }
    }
}
