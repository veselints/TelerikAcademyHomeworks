// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value.
// Override ToString() to display the information of a person and if age is not specified – to say so.
// Write a program to test this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Person
    {
        private int? age;
        private string name;

        public Person(int? age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public Person(string name)
            : this(null, name)
        { }
        
        public int? Age
        {
            get { return age; }
            private set
            {
                try
                {
                    if (value < 0 || value > 200)
                    {
                        throw new ArgumentException("The person's age must be between 0 and 200!");
                    }
                    else
                    {
                        age = value;
                    }
                }
                catch (Exception e)
                {                    
                    throw new ArgumentException(e.Message);
                }
            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The name is too short!");
                }
                name = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return String.Format("{0}, Age is not specified", this.Name);
            }
            return String.Format("{0}, {1}", this.Name, this.Age);
        }
    }
}
