// Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

// Implement an indexer this[row, col] to access the inner matrix cells.

// Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
// Throw an exception when the operation cannot be performed.
// Implement the true operator (check for non-zero elements)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems8to10
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> testMatrix = new Matrix<int>(4, 3); //creates an int matrix w/ 4 rows and 3 cols, all cells = 0

            testMatrix[1, 1] = 5; // setting value to a cell and printing it
            Console.WriteLine("Matrix[1,1] = {0}", testMatrix[1, 1]);

            Matrix<int> matrix1 = new Matrix<int>(3, 3); //two matrices for testing +, - and *
            Matrix<int> matrix2 = new Matrix<int>(3, 3);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    matrix1[i, j] = (i + 3) * (j + 1) + 5;
                    matrix2[i, j] = (i + 1) * (j + 2);
                }
            }

            Console.WriteLine("Matrix 1:\n{0}", matrix1);
            Console.WriteLine("Matrix 2:\n{0}", matrix2);

            Matrix<int> resultOfAddition = matrix1 + matrix2;
            Matrix<int> resultOfSubtraction = matrix1 - matrix2;
            Matrix<int> resultOfMultiplication = matrix1 * matrix2;

            Console.WriteLine("Matrix1 + Matrix2 =\n{0}", resultOfAddition);
            Console.WriteLine("Matrix1 - Matrix2 =\n{0}", resultOfSubtraction);
            Console.WriteLine("Matrix1 * Matrix2 =\n{0}", resultOfMultiplication);

        }
    }
}
