// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;

class Problem1SayHello
{
    static void Main()
    {
        SayHello();
    }
    public static void SayHello()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}