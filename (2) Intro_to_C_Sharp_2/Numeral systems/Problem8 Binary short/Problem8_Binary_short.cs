// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class Problem8_Binary_short
{
    static void Main()
    {
        Console.Write("Enter a short number: ");
        short input = short.Parse(Console.ReadLine());

        string inputToBinary = ShortToBinary(input);

        Console.WriteLine("Number: {0}\nSign: {1} Number: {2}", input, inputToBinary[0],
            inputToBinary.Substring(1, 15));
    }
    static string ShortToBinary(short number)
    {
        byte[] bytesInput = BitConverter.GetBytes(number);
        string inputToBinary = "";
        for (int i = 0; i < bytesInput.Length; i++)
        {
            inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
        }
        return inputToBinary;
    }
}
