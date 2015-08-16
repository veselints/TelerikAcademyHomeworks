
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Discipline : Commentable
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;

        public string Name
        {
            get { return this.disciplineName; }
            private set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("The name is too short!");
                }
                else
                {
                    this.disciplineName = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set
            {
                try
                {
                    if (value < 2)
                    {
                        Console.WriteLine("Each discipline must have at least two lectures!");
                    }
                    else
                    {
                        this.numberOfLectures = value;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            private set
            {
                try
                {
                    if (value < 2)
                    {
                        Console.WriteLine("Each discipline must have at least two exercises!");
                    }
                    else
                    {
                        this.numberOfExercises = value;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
        }

        public Discipline(string name, int lectures, int exercises, string comment)
        : this (name, lectures, exercises)
        {
            this.Comment = comment;
        }
    }
}
