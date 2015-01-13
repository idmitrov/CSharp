// Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }

    }
}
