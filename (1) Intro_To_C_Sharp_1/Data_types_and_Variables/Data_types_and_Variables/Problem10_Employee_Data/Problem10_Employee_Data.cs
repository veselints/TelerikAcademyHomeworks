//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class Problem10_Employee_Data
{
    static void Main()
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine("What is your current age?");
        byte age = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("What is your gender? m/f");
        char gender = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("What is your personal ID number?");
        long IDNumber = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("What is your employee number?");
        int employeeNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your name is {0} {1}.", firstName, lastName);
        Console.WriteLine("Your age is {0}.", age);
        Console.WriteLine("Your gender is {0}.", gender);
        Console.WriteLine("Your personal ID number is {0}.", IDNumber);
        Console.WriteLine("Your unique employee number is {0}.", employeeNumber);
    }
}
