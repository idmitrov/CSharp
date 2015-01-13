/*
     Write a program that gets two numbers from the console and prints the greater of them.
     Try to implement this without if statements.
 */
using System;

class NumberComparer
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine());
        Console.WriteLine(a > b ? a : b);
      //Console.WriteLine(Math.Max(a, b));
    }
}
