namespace Loops
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool valueFound = false;

            for (i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (array[i] == expectedValue)
                {
                    valueFound = true;
                    break;
                }
            }
            // More code here

            if (valueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
