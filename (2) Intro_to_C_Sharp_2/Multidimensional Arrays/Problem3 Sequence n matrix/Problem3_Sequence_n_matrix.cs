// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class Problem3_Sequence_n_matrix
{
    static void Main()
    {
        Console.WriteLine("Give us the dimention of the matrix");
        Console.Write("n = ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = Int32.Parse(Console.ReadLine());

        string[,] stringArray = new string[n, m];
        for (int i = 0; i < stringArray.GetLength(0); i++)
        {
            for (int j = 0; j < stringArray.GetLength(1); j++)
            {
                stringArray[i, j] = Console.ReadLine();
            }
        }

        int currentSequence = 1;
        int maxSequence = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int direction = 0;

        for (int row = 0; row < stringArray.GetLength(0); row++)
        {
            for (int col = 0; col < stringArray.GetLength(1); col++)
            {
                for (int i = col + 1; i < stringArray.GetLength(1); i++)
                {
                    if (stringArray[row, i] == stringArray[row, col])
                    {
                        currentSequence++;
                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;
                            bestRow = row;
                            bestCol = col;
                            direction = 1;
                        }
                    }
                }
                currentSequence = 1;
                for (int i = row + 1; i < stringArray.GetLength(0); i++)
                {
                    if (stringArray[i, col] == stringArray[row, col])
                    {
                        currentSequence++;
                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;
                            bestRow = row;
                            bestCol = col;
                            direction = 2;
                        }
                    }
                }
                currentSequence = 1;
                if (n - row <= m - col)
                {
                    for (int i = 0; i < n - row - 1; i++)
                    {
                        if (stringArray[row + i + 1, col + i + 1] == stringArray[row, col])
                        {
                            currentSequence++;
                            if (currentSequence > maxSequence)
                            {
                                maxSequence = currentSequence;
                                bestRow = row;
                                bestCol = col;
                                direction = 3;
                            }
                        }
                    }
                    currentSequence = 1;
                }
                else
                {
                    for (int i = 0; i < m - col - 1; i++)
                    {
                        if (stringArray[row + i + 1, col + i + 1] == stringArray[row, col])
                        {
                            currentSequence++;
                            if (currentSequence > maxSequence)
                            {
                                maxSequence = currentSequence;
                                bestRow = row;
                                bestCol = col;
                                direction = 3;
                            }
                        }
                    }
                    currentSequence = 1;
                }
            }
        }
        if (direction == 1)
        {
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write("{0} ", stringArray[bestRow, bestCol + i]);
            }
            Console.WriteLine();
            Console.WriteLine("The sequence is from position [{0}, {1}] to position [{2}, {3}]", bestRow, bestCol, bestRow, bestCol + maxSequence - 1);
        }
        else if (direction == 2)
        {
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write("{0} ", stringArray[bestRow + i, bestCol]);
            }
            Console.WriteLine();
            Console.WriteLine("The sequence is from position [{0}, {1}] to position [{2}, {3}]", bestRow, bestCol, bestRow + maxSequence - 1, bestCol);
        }
        else if (direction == 3)
        {
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write("{0} ", stringArray[bestRow + i, bestCol + i]);
            }
            Console.WriteLine();
            Console.WriteLine("The sequence is from position [{0}, {1}] to position [{2}, {3}]", bestRow, bestCol, bestRow + maxSequence - 1, bestCol + maxSequence - 1);
        }
    }
}
