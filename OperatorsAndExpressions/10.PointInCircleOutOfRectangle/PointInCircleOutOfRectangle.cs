/*
 Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
 R(top=1, left=-1, width=6, height=2).
 */
using System;
using System.Threading;
using System.Globalization;

class PointInCircleOutOfRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        double x = double.Parse(Console.ReadLine()),
               y = double.Parse(Console.ReadLine()),
               radius = 1.5;
        bool isInCircle = (Math.Pow(x - 1, 2)) + (Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2),
             isInRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);
        
        Console.WriteLine(isInCircle && !isInRectangle ? "yes" : "no");
    }
}
