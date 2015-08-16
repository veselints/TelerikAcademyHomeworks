namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;
    using System;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name)
            : base(name)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        public string Town
        {
            get { return this.town; }
            set
            {
                if (value != String.Empty)
                {
                    this.town = value;
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
            result.Append("OffsiteCourse");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
