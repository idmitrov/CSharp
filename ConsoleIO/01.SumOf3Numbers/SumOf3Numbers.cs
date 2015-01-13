// Write a program that reads 3 real numbers from the console and prdoubles their sum.
using System;

class SumOf3Numbers
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               c = double.Parse(Console.ReadLine());
        Console.WriteLine(a + b + c);
    }
}
