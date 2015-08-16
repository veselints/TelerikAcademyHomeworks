using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var testPerson1 = new Person(28, "Pesho");
            var testPerson2 = new Person("Georgi");

            Console.WriteLine(testPerson1);
            Console.WriteLine(testPerson2);
        }
    }
}
