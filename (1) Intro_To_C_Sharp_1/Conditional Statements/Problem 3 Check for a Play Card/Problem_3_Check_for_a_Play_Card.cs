// Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
// Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;
using System.Linq;

class Problem_3_Check_for_a_Play_Card
{
    static void Main()
    {
        string[] playcards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        Console.WriteLine("Please, choose a playcard:");
        string chosenCard = Console.ReadLine();

        if (Array.Exists(playcards, element => element == chosenCard))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
