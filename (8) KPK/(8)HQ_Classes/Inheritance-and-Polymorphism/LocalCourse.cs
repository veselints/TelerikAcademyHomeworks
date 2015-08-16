namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;
    using System;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name)
            : base(name)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        public string Lab
        {
            get { return this.lab; }
            set
            {
                if (value != String.Empty)
                {
                    this.lab = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse");
            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
