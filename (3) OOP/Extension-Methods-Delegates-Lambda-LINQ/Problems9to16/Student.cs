using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems9to16
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int FacultyNumber { get; private set; }
        public string Telephone { get; private set; }
        public string Email { get; private set; }
        public IList<int> Marks { get; private set; }
        public int GroupNumber { get; private set; }

        public Student(string FirstName, string LastName, int FacultyNumber, string Telephone, string Email, IList<int> marks, int GroupNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.FacultyNumber = FacultyNumber;
            this.Telephone = Telephone;
            this.Email = Email;
            this.Marks = marks;
            this.GroupNumber = GroupNumber;            
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
