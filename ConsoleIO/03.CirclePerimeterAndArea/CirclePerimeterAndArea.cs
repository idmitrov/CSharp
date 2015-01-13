/*
     Write a program that reads the radius r of a circle and prints its perimeter and area 
     formatted with 2 digits after the decimal point.
 */
using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine()),
               perimeter = 2 * Math.PI * radius,
               area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Perimeter: {0:F}\r\nArea: {1:0.00}", perimeter, area);
    }
}
