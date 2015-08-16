// Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class Problem1_Fill_the_matrix
{
    static void Main()
    {
        Console.Write("Give us the dimention of the matrix n = ");
        int n = Int32.Parse(Console.ReadLine());

        int[,] intArrayA = new int[n,n];
        for (int row = 0; row < intArrayA.GetLength(0); row++)
        {
            for (int col = 0; col < intArrayA.GetLength(1); col++)
            {
                intArrayA[row, col] = 1 + col * n + row; 
            }
        }
        for (int row = 0; row < intArrayA.GetLength(0); row++)
        {
            for (int col = 0; col < intArrayA.GetLength(1); col++)
            {
                Console.Write("{0} ", Convert.ToString(intArrayA[row, col]).PadLeft(3));
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int[,] intArrayB = new int[n, n];
        for (int row = 0; row < intArrayB.GetLength(0); row++)
        {
            for (int col = 0; col < intArrayB.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    intArrayB[row, col] = 1 + col * n + row;
                }
                else
                {
                    intArrayB[row, col] = n + n * col - row;
                }
            }
        }
        for (int row = 0; row < intArrayB.GetLength(0); row++)
        {
            for (int col = 0; col < intArrayB.GetLength(1); col++)
            {
                Console.Write("{0} ", Convert.ToString(intArrayB[row, col]).PadLeft(3));
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int[,] intArrayC = new int[n, n];

        int value = 1;
        for (int row = intArrayC.GetLength(0) - 1; row >= 0; row--)
        {
            int rows = row;
            int cols = 0;
            while (rows < intArrayC.GetLength(0) && cols < intArrayC.GetLength(1))
            {
                intArrayC[rows++, cols++] = value++;
            }
        }
        for (int col = 1; col < intArrayC.GetLength(1); col++)
        {
            int rows = 0;
            int cols = col;
            while (rows < intArrayC.GetLength(0) && cols < intArrayC.GetLength(1))
            {
                intArrayC[rows++, cols++] = value++;
            }
        }
    }
}
