// Write a program that compares two char arrays lexicographically (letter by letter)

using System;

class Problem3_Compare_char_arrays
{
    static void Main()
    {
        Console.Write("Give us the lenght of the two char arrays: ");
        int n = Int32.Parse(Console.ReadLine());

        char[] firstArray = new char[n];
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = Convert.ToChar(Console.ReadLine());
        }

        char[] secondArray = new char[n];
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = Convert.ToChar(Console.ReadLine());
        }

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("firstArray[{0}] = secondArray[{0}] ({1} = {2})", i, firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("firstArray[{0}] != secondArray[{0}] ({1} != {2})", i, firstArray[i], secondArray[i]);
            }
        }
    }
}
