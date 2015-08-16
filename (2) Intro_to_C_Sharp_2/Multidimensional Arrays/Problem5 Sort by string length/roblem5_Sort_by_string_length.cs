// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class roblem5_Sort_by_string_length
{
    static void Main()
    {
        Console.Write("Give us the lenght of the array: ");
        int n = Int32.Parse(Console.ReadLine());

        string[] stringArray = new string[n];

        Console.WriteLine("Tell us the strings in the array: ");
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = Console.ReadLine();
        }

        if (stringArray.Length == 1)
        {
            Console.WriteLine(stringArray[0]);
        }
        else
        {
            Array.Sort(stringArray, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string element in stringArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
