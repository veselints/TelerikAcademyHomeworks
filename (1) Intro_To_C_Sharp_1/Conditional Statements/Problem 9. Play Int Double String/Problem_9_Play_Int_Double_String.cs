// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;

class Problem_9_Play_Int_Double_String
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choise = Int32.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.Write("Please enter an integer number: ");
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
            }
            else if (choise == 2)
            {
                Console.Write("Please enter a floating point number: ");
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine(number + 1);
            }
            else if (choise == 3)
            {
                Console.Write("Please enter a string: ");
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}