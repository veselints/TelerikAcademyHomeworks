// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class Problem2_Maximal_sum
{
    static void Main()
    {
        Console.WriteLine("Give us the dimention of the matrix");
        Console.Write("n = ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = Int32.Parse(Console.ReadLine());
        if (n < 3 || m < 3)
        {
            Console.WriteLine("You have given invalid input!");
        }

        else
        {
            int[,] intArray = new int[n, m];
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    intArray[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            int maxSum = int.MaxValue;
            int currentSum = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < intArray.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < intArray.GetLength(0) - 2; col++)
                {
                    currentSum = intArray[row, col] + intArray[row, col + 1] + intArray[row, col + 2] + intArray[row + 1, col] + intArray[row + 1, col + 1] + intArray[row + 1, col + 2] + intArray[row + 2, col] + intArray[row + 2, col + 1] + intArray[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", intArray[maxRow + i, maxCol + j]);
                }
                Console.WriteLine();
            }
        }
    }
}
