namespace PrintStatistics
{
    using System;

    public class Statistics
    {
        public static void Main(string[] args)
        {
        }

        public void PrintStatistics(double[] inputArray)
        {
            double max = FindMax(inputArray);

            Print(max);

            double min = FindMin(inputArray);

            Print(min);

            double avarage = FindAvarage(inputArray);

            Print(avarage);
        }

        private double FindMax(double[] inputArray)
        {
            double max = double.MinValue;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > max)
                {
                    max = inputArray[i];
                }
            }

            return max;
        }

        private double FindMin(double[] inputArray)
        {
            double min = double.MaxValue;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < min)
                {
                    min = inputArray[i];
                }
            }

            return min;
        }

        private double FindAvarage(double[] inputArray)
        {
            double sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
            }

            double avarage = sum / inputArray.Length;

            return avarage;
        }

        private void Print(double number)
        {
            Console.WriteLine(number);
        }
    }
}
