using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    public abstract class Animal
    {
        private int age;
        private string name;
        private bool isMale;
        
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                try
                {
                    if (value < 0 || value > 100)
                    {
                        Console.WriteLine("The animal should be between 0 and 100 years old!");
                    }
                    else
                    {
                        this.age = value;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
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

        public bool IsMale
        {
            get
            {
                return this.IsMale;
            }
            private set
            {
                try
                {
                    this.isMale = value;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }

        public Animal(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        public static double CalculateAvarageAge(IList<Animal> list, string animal)
        {
            var result =
                from animals in list
                where animals.GetType().ToString() == ("AnimalHierarchy." + animal)
                select animals;

            double avarageAge = 0;
            int numberOfAnimals = 0;

            foreach (var item in result)
            {
                avarageAge += item.Age;
                numberOfAnimals++;
            }

            return avarageAge / numberOfAnimals;
        }
    }
}
