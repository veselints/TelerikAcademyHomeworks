﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems8to10
{
    public class Matrix<T>
        where T : struct, IComparable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rowCout, int colCount)
        {
            this.Rows = rowCout;
            this.Cols = colCount;
            this.matrix = new T[rowCout, colCount];
        }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row >= this.Rows) ||
                    (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("rows count", "The matrix must have at least one row.");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("columns count", "The matrix must have at least one column.");
                }
                this.cols = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
            {
                throw new Exception("Addition cannot be applied to matrices with different dimensions.");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] + b[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Cols || a.Rows != b.Rows)
            {
                throw new Exception("Substraction cannot be applied to matrices with different dimensions.");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            for (int row = 0; row < a.Rows; row++)
            {
                for (int col = 0; col < a.Cols; col++)
                {
                    result[row, col] = (dynamic)a[row, col] - b[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.Cols != b.Rows)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }

            Matrix<T> result = new Matrix<T>(a.Rows, b.Cols);
            T temp;

            for (int matrixRow = 0; matrixRow < result.Rows; matrixRow++)
            {
                for (int matrixCol = 0; matrixCol < result.Cols; matrixCol++)
                {
                    temp = (dynamic)0;
                    for (int index = 0; index < result.Cols; index++)
                    {
                        temp += (dynamic)a[matrixRow, index] * b[index, matrixCol];
                    }
                    result[matrixRow, matrixCol] = (dynamic)temp;
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result.Append(String.Format("{0, 5}", this.matrix[i, j]));
                }
                result.Append(Environment.NewLine);
            }
            
            return result.ToString();
        }
    }
}
