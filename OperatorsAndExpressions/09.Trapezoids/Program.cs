// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               h = double.Parse(Console.ReadLine()),
               area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}
