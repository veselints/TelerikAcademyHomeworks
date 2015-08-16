using System;

namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;
 
        protected Course(string courseName)
            : this(courseName, null, new List<string>())
        {
        }

        protected Course(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>())
        {
        }

        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != String.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public string TeacherName
        {
            get { return this.teacherName; }
            set
            {
                if (value != String.Empty)
                {
                    this.teacherName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public IList<string> Students
        {
            get { return this.students; }
            set
            {
                if (ValidateEachStudentInput(value))
                {
                    this.students = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            
            return "{ " + string.Join(", ", this.Students) + " }";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(" { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            result.Append(" }");
            return result.ToString();
        }

        private bool ValidateEachStudentInput(IList<string> listToCheck)
        {
            for (int i = 0; i < listToCheck.Count; i++)
            {
                if (listToCheck[i] == String.Empty)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
