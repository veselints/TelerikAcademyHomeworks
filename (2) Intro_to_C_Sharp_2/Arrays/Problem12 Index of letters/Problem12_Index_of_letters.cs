// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

class Problem12_Index_of_letters
{
    static void Main()
    {
        char[] alfabet = new char[26];

        for (int i = 0; i < alfabet.Length; i++)
        {
            alfabet[i] = Convert.ToChar(97 + i);
        }

        string text = Console.ReadLine();
        char[] textArray;
        textArray = text.ToCharArray();

        for (int i = 0; i < textArray.Length; i++)
        {
            for (int j = 0; j < alfabet.Length; j++)
            {
                if (textArray[i] == alfabet[j])
                {
                    Console.WriteLine("{0} = intex {1}", textArray[i], j);
                }
            }
        }
    }
}
