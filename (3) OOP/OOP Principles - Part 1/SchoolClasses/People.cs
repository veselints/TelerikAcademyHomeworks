using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public abstract class People : Commentable
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            protected set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("The name is too short!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
