// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals.
// All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex.
// Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
// Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class TestAnimals
    {
        static void Main(string[] args)
        {

            Animal[] animalList = new Animal[]
            {
                new Cat(8, "Sheakspeer", true),
                new Dog(4, "Koki", true),
                new Frog(20, "Arko", true),
                new Cat(68, "Silvester", true),
                new Cat(34, "Garfield", true),
                new Dog(5, "Ava", true),
                new Kitten(1, "Smilie"),
                new Tomcat(80, "Tom")
            };

            double result = Animal.CalculateAvarageAge(animalList, "Frog");
            double result2 = Animal.CalculateAvarageAge(animalList, "Dog");
            double result3 = Animal.CalculateAvarageAge(animalList, "Cat");
            double result4 = Animal.CalculateAvarageAge(animalList, "Kitten");

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}
