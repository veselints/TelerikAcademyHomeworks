using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems3to5
{
    class Student
    {

        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException("Age must be between 0 and 150");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + ", " + this.age + "-years-old";
        }
    }
}
