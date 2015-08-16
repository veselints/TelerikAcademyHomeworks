using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Teacher : People
    {
        private Discipline[] teacherDisciplines;

        public Discipline[] TeacherDisciplines
        {
            get { return this.teacherDisciplines; }
            private set
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("You have not entered any disciplines!");
                }
                else
                {
                    this.teacherDisciplines = new Discipline[value.Length];
                    for (int i = 0; i < value.Length; i++)
                    {
                        this.teacherDisciplines[i] = value[i];
                    }
                }
            }
        }

        public Teacher(Discipline[] disciplines, string name)
        {
            this.TeacherDisciplines = disciplines;
            Name = name;
        }

        public Teacher(Discipline[] disciplines, string name, string comment)
            : this(disciplines, name)
        {
            this.Comment = comment;
        }
    }
}
