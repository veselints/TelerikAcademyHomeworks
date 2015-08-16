namespace PrintBoolean
{
    using System;

    public class PrintBoolean
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            BoolenPrinter.Print(true);
        }

        public class BoolenPrinter
        {
            public static void Print(bool input)
            {
                string inputAsString = input.ToString();
                Console.WriteLine(inputAsString);
            }
        }
    }
}
