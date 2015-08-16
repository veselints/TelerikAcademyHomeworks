namespace P2EvenDifferences
{
    using System;

    class EvenDifferences
    {
        static void Main()
        {
            long[] numbersArray = ReadInput(Console.ReadLine());

            long sumOfEvenDifferences = CalculateSumOfDiferences(numbersArray);
            
            Console.WriteLine(sumOfEvenDifferences);
        }

        private static long[] ReadInput(string input)
        {
            char[] splitter = { ' ' };
            string[] inputStrings = input.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            long[] numbersArray = new long[inputStrings.Length];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = Convert.ToInt64(inputStrings[i]);
            }

            return numbersArray;
        }

        private static long CalculateSumOfDiferences(long[] numbersArray)
        {
            long sumOfEvenDifferences = 0;
            int currentIndex = 1;

            while (currentIndex < numbersArray.Length)
            {
                long currentDifference = Math.Abs(numbersArray[currentIndex] - numbersArray[currentIndex - 1]);

                if (currentDifference % 2 == 0)
                {
                    sumOfEvenDifferences += currentDifference;
                    currentIndex += 2;
                }
                else
                {
                    currentIndex += 1;
                }
            }

            return sumOfEvenDifferences;
        }
    }
}
