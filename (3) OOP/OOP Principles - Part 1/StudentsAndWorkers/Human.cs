using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("The name is too short!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("The name is too short!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public Human(string firstName, string lastName)
        // : base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
