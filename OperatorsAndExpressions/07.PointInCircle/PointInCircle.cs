// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
using System;
using System.Threading;
using System.Globalization;

class PointInCircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double x = double.Parse(Console.ReadLine()),
               y = double.Parse(Console.ReadLine());
        int radius = 2;
        Console.WriteLine(Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2) ? true : false);

        //bool isInCircle = false;
        //if (x * x + y * y <= radius * radius)
        //{
        //    isInCircle = true;
        //}
        //Console.WriteLine(isInCircle);
    }
}
