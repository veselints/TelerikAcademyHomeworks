
// Define a class Student, which contains data about a student – first, middle and last name, SSN,
// permanent address, mobile phone e-mail, course, specialty, university, faculty.
// Use an enumeration for the specialties, universities and faculties.
// Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

// Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student

// Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
// and by social security number (as second criteria, in increasing order).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1to3StudentClass.StudentProperties;

namespace _1to3StudentClass
{
    class Student : ICloneable, IComparable<Student>
    {
        public PersonalDetails PersonalDetails { get; private set; }

        public Contacts Contacts { get; private set; }

        public UniversityInfo UniversityInfo { get; private set; }

        public Student( PersonalDetails pd, Contacts contacts, UniversityInfo UI)
        {
            this.PersonalDetails = pd;
            this.Contacts = contacts;
            this.UniversityInfo = UI;
        }

        public override string ToString()
        {
            string strudentToString = String.Format("{0};\r\n{1};\r\n{2}", this.PersonalDetails, this.Contacts, this.UniversityInfo);
            return strudentToString;
        }

        public bool Equals(Student secondStudent)
        {
            if ((object)secondStudent == null)
            {
                return false;
            }
            return this.PersonalDetails.SocialSecurityNumber == secondStudent.PersonalDetails.SocialSecurityNumber;
        }

        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            if (firstStudent.PersonalDetails.SocialSecurityNumber == secondStudent.PersonalDetails.SocialSecurityNumber)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.PersonalDetails.SocialSecurityNumber == secondStudent.PersonalDetails.SocialSecurityNumber)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + this.PersonalDetails.SocialSecurityNumber.GetHashCode();
            return hash;
        }

        public Student Clone()
        {
            Student newStudent = new Student(
                new PersonalDetails(this.PersonalDetails.FirstName, this.PersonalDetails.MiddleName, this.PersonalDetails.LastName, this.PersonalDetails.SocialSecurityNumber),
                new Contacts(this.Contacts.Addresss, this.Contacts.MobilePhone, this.Contacts.EMail),
                new UniversityInfo(this.UniversityInfo.Course, this.UniversityInfo.Specialty, this.UniversityInfo.University, this.UniversityInfo.Faculty)
                );

            return newStudent;
        }

        object ICloneable.Clone()
        {
            Object newStudent = new Student(
                new PersonalDetails(this.PersonalDetails.FirstName, this.PersonalDetails.MiddleName, this.PersonalDetails.LastName, this.PersonalDetails.SocialSecurityNumber),
                new Contacts(this.Contacts.Addresss, this.Contacts.MobilePhone, this.Contacts.EMail),
                new UniversityInfo(this.UniversityInfo.Course, this.UniversityInfo.Specialty, this.UniversityInfo.University, this.UniversityInfo.Faculty)
                );

            return newStudent;
        }

        int IComparable<Student>.CompareTo(Student other)
        {
            if (this.PersonalDetails.FirstName != other.PersonalDetails.FirstName)
            {
                return this.PersonalDetails.FirstName.CompareTo(other.PersonalDetails.FirstName);
            }
            else
	        {
                if (this.PersonalDetails.MiddleName != other.PersonalDetails.MiddleName)
                {
                    return this.PersonalDetails.MiddleName.CompareTo(other.PersonalDetails.MiddleName);
                }
                else
                {
                    if (this.PersonalDetails.LastName != other.PersonalDetails.LastName)
                    {
                        return this.PersonalDetails.LastName.CompareTo(other.PersonalDetails.LastName);
                    }
                    else
                    {
                        if (this.PersonalDetails.SocialSecurityNumber != other.PersonalDetails.SocialSecurityNumber)
                        {
                            return this.PersonalDetails.SocialSecurityNumber.CompareTo(other.PersonalDetails.SocialSecurityNumber);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }

	        }
        }
    }
}
