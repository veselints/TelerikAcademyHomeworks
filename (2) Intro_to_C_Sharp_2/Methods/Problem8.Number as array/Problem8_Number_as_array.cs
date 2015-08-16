// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;

class Problem8_Number_as_array
{
    static void Main()
    {
        Console.WriteLine("Give us the first integer number a = ");
        string stringA = Console.ReadLine();
        Console.WriteLine("Give us the second integer number b = ");
        string stringB = Console.ReadLine();

        int[] arrayA = CreateDigitArray(stringA);
        int[] arrayB = CreateDigitArray(stringB);

        int[] result = AddTwoIntegerArrays(arrayA, arrayB);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    public static int[] CreateDigitArray(string stringNumber)
    {
        int[] numberArray = new int[stringNumber.Length];
        for (int i = 0; i < stringNumber.Length; i++)
        {
            numberArray[i] = stringNumber[stringNumber.Length - 1 - i] - 48;
        }
        return numberArray;
    }

    public static int[] AddTwoIntegerArrays(int[] firstArray, int[] secondArray)
    {
        int lenght = 0;
        int shorter = 0;
        int occasion = 0;
        if ((firstArray.Length == secondArray.Length) && ((firstArray[firstArray.Length - 1] + secondArray[secondArray.Length - 1] >= 10) || ((firstArray[firstArray.Length - 1] + secondArray[secondArray.Length - 1] == 9) && (firstArray[firstArray.Length - 2] + secondArray[secondArray.Length - 2] >= 10))))
        {
            lenght = firstArray.Length + 1;
            shorter = firstArray.Length;
            occasion = 1;
        }
        else
        {
            if (firstArray.Length >= secondArray.Length)
            {
                lenght = firstArray.Length;
                shorter = secondArray.Length;
                occasion = 2;
            }
            else
            {
                lenght = secondArray.Length;
                shorter = firstArray.Length;
                occasion = 3;
            }
        }
        int[] result = new int[lenght];

        for (int i = 0; i < shorter; i++)
        {
            result[i] = firstArray[i] + secondArray[i];
            if (result[i] >= 10)
            {
                if (occasion == 2)
                {
                    firstArray[i + 1] += 1;
                    result[i] = result[i] % 10;
                }
                else if (occasion == 3)
                {
                    secondArray[i + 1] += 1;
                    result[i] = result[i] % 10;
                }
                else
                {
                    if (i < shorter - 1)
                    {
                        secondArray[i + 1] += 1;
                        result[i] = result[i] % 10;
                    }
                    else
                    {
                        result[i] = result[i] % 10;
                    }
                }
            }
        }
        if (occasion == 1)
        {
            result[lenght - 1] = 1;
        }
        else if (occasion == 2)
        {
            for (int i = shorter; i < lenght; i++)
            {
                result[i] = firstArray[i];
            }
        }
        else if (occasion == 3)
        {
            for (int i = shorter; i < lenght; i++)
            {
                result[i] = secondArray[i];
            }
        }
        return result; 
    }

    // public static int[] AddTwoIntegers
}