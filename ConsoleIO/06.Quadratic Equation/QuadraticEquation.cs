/*
     Write a program that reads the coefficients a, b and c of a quadratic equation
     ax2 + bx + c = 0 and solves it (prints its real roots).
*/

using System;

class QuadraticEquation
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               c = double.Parse(Console.ReadLine()),
               discriminant = (Math.Pow(b, 2)) - (4 * a * c),
               xOne = ((-b - Math.Sqrt(discriminant)) / (2 * a)),
               xTwo = ((-b + Math.Sqrt(discriminant)) / (2 * a));

        if (discriminant < 0)
        {
            Console.WriteLine("No real roots!");
        }
        else if (xOne == xTwo)
        {
            Console.WriteLine("x1 = x2 = {0}", xOne);
        }
        else
        {
            Console.WriteLine("x1 = {0}\r\nx2 = {1}", xOne, xTwo);
        }
    }
}
