using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1to3StudentClass.StudentProperties.UniversityEnums;

namespace _1to3StudentClass.StudentProperties
{
    class UniversityInfo
    {
        // course, specialty, university, faculty

        private int course;

        public UniversityInfo(int course, Specialty spec, University uni, Faculty fac)
        {
            this.Course = course;
            this.Specialty = spec;
            this.University = uni;
            this.Faculty = fac;
        }

        public int Course
        {
            get { return course; }
            private set
            {
                try
                {
                    if (value < 1 || value > 5)
                    {
                        throw new ArgumentOutOfRangeException("The course number could be between 1 and 5!");
                    }
                    else
                    {
                        course = value;
                    }
                }
                catch (Exception e)
                {
                    throw new ArgumentException(e.Message);
                }
            }
        }

        public Specialty Specialty { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        public override string ToString()
        {
            string universityInfoToString = String.Format("{0}, {1}, {2}, {3}", this.Course, this.Specialty, this.University, this.Faculty);
            return universityInfoToString;
        }
    }
}
