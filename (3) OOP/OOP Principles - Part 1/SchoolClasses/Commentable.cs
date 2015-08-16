using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public abstract class Commentable
    {
        private string comment;

        public string Comment
        {
            get { return comment; }
            set
            {
                if (value == String.Empty)
                {
                    Console.WriteLine("You have not entered a comment!");
                }
                else
                {
                    comment = value;
                }
            }
        }
    }
}
