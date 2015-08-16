using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
            : base(age, name, true)
        { }
    }
}
