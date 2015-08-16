using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, bool isMale)
            : base(age, name, isMale)
        { }

        public void ProduceSound()
        {
            Console.WriteLine("Mauuuuuuuuuuu");
        }
    }
}
