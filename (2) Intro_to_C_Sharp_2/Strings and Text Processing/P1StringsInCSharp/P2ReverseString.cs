using System;
using System.Text;

class P2ReverseString
{
    static void Main()
    {
        Console.WriteLine("Give us a string:");
        string input = Console.ReadLine();

        StringBuilder redo = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            redo.Append(input[i]);
        }
        string output = Convert.ToString(redo);

        Console.WriteLine("The result is {0}.", output);
    }
}
