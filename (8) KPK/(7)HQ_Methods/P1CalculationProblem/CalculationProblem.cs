namespace P1CalculationProblem
{
    using System;
    using System.Text;

    class CalculationProblem
    {
        private const int ValueOfLetterA = 97;
        private const int NumericSystem = 23;

        static void Main()
        {
            string[] inputStrings = ReadInput(Console.ReadLine());

            long decimalResult = CalculateDecimalResult(inputStrings);
            string twentyhTreeBasedResult = Calculate23BasedResult(decimalResult);
     
            Console.WriteLine("{0} = {1}", twentyhTreeBasedResult, decimalResult);
        }

        private static string[] ReadInput(string input)
        {
            char[] splitter = { ' ' };
            string[] inputStrings = input.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            return inputStrings;
        }

        private static long CalculateDecimalResult(string[] inputStrings)
        {
            long decimalResult = 0;
            for (int i = 0; i < inputStrings.Length; i++)
            {
                long currentDecimalResult = 0;
                string currentInputString = inputStrings[i];
                int currentInputSTringLength = currentInputString.Length;

                for (int j = 0; j < currentInputSTringLength; j++)
                {
                    char currentAbsoluteCharValue = currentInputString[currentInputSTringLength - 1 - j];
                    int currentActualCharValue = currentAbsoluteCharValue - ValueOfLetterA;
                    currentDecimalResult += currentActualCharValue * (long)Math.Pow(NumericSystem, j);
                }

                decimalResult += currentDecimalResult;
            }

            return decimalResult;
        }

        private static string Calculate23BasedResult(long decimalForCalculations)
        {
            StringBuilder twentyhTreeBasedResult = new StringBuilder();

            if (decimalForCalculations == 0)
            {
                twentyhTreeBasedResult.Append('a');
            }
            else
            {
                while (decimalForCalculations > 0)
                {
                    long currentNumericResultIn23BasedSystem = decimalForCalculations % NumericSystem;
                    char currentLetter = Convert.ToChar(currentNumericResultIn23BasedSystem + ValueOfLetterA);
                    twentyhTreeBasedResult.Insert(0, currentLetter);
                    decimalForCalculations = decimalForCalculations / NumericSystem;
                }
            }

            return twentyhTreeBasedResult.ToString();
        }
    }
}
