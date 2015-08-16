using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1to3StudentClass.StudentProperties
{
    class PersonalDetails
    {
        // first, middle and last name, SSN

        private string firstName;
        private string middleName;
        private string lastName;
        private long socialSecurityNumber;

        public PersonalDetails(string firstName, string middleName, string lastName, long socialSecurityNumber)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
        }

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The name is too short!");
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The name is too short!");
                }
                else
                {
                    middleName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The name is too short!");
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public long SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            private set
            {
                if(value.ToString().Length != 10)
                {
                    throw new ArgumentException("The social security number must be 10 digits!");
                }
                else
                {
                    socialSecurityNumber = value; 
                }
            }
        }
        

        public override string ToString()
        {
            string personalDetailsToString = String.Format("{0}, {1}, {2}, {3}", this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber);
            return personalDetailsToString;
        }
    }
}
