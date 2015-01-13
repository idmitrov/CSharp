// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               c = double.Parse(Console.ReadLine()),
               d = double.Parse(Console.ReadLine()),
               e = double.Parse(Console.ReadLine()),
               biggest = 0;
        //A
        if (a >= b && a >= c && a >= d && a >= e)
        {
            biggest = a;
        }
        //B
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            biggest = b;
        }
        //C
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            biggest = c;
        }
        //D
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            biggest = d;
        }
        //E
        else if (e >= a && e >= b && e >= c && e >= d)
        {
            biggest = e;
        }
        Console.WriteLine(biggest);
    }
}
