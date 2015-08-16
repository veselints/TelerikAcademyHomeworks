// Thee gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class Problem_2_Gravitation_on_the_Moon
{
    static void Main()
    {
        Console.WriteLine("Tell us what is your weight?");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weghtOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("Your weihgt on Moon should be only {0} kg.", weghtOnMoon);
    }
}