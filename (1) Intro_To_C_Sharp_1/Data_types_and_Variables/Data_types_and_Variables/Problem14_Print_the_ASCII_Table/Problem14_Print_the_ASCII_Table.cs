﻿//Find online more information about ASCII (American Standard Code for Information Interchange)
//and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

using System;

class Problem14_Print_the_ASCII_Table
{
    static void Main()
    {
        for (char charactersASCII = (char)0; charactersASCII <= 255; charactersASCII++)
        {
            Console.WriteLine(charactersASCII);
        }
    }
}
