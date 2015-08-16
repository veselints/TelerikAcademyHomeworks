namespace CreatePerson
{
    using System;

    public class CreatePersonMainClass
    {
        public enum Sex 
        {
            male,
            female
        }

        public class Person
        {
            public Person(int age)
            {
                this.Age = age;

                if (age % 2 == 0)
                {
                    this.Name = "Батката";
                    this.PersonSex = Sex.male;
                }
                else
                {
                    this.Name = "Мацето";
                    this.PersonSex = Sex.female;
                }
            }

            public Sex PersonSex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
