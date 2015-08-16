using System;

class Problem5_Maximal_increasing_sequence
{
    static void Main()
    {
        Console.Write("Give us the lenght of the array: ");
        int n = Int32.Parse(Console.ReadLine());

        int[] intArray = new int[n];

        Console.WriteLine("Tell us the numbers in the array: ");
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = Int32.Parse(Console.ReadLine());
        }

        int currSequence = 1;
        int maxSequence = 0;
        int maxElement = 0;
        int currElement = intArray[0];

        if (intArray.Length == 1)
        {
            maxElement = currElement;
            maxSequence = 1;
        }

        for (int i = 1; i < intArray.Length; i++)
        {
            if (intArray[i] >= intArray[i - 1])
            {
                currSequence++;
            }
            else
            {
                currElement = i;
                currSequence = 1;
            }

            if (currSequence >= maxSequence)
            {
                maxSequence = currSequence;
                maxElement = currElement;
            }
        }

        Console.Write("The maximal increasing sequence in the array is: ");
        for (int i = maxElement - maxSequence; i < maxElement; i++)
        {
            Console.Write("{0} ", intArray[i]);
        }
        Console.WriteLine();
    }
}
