/*
    Write a program that enters 3 real numbers and prints them sorted in descending order.
    Use nested if statements.
 */

using System;

class SortNumbersWithNestedIfs
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               c = double.Parse(Console.ReadLine());

        if (a >= b && b >= c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c); //ABC
        }
        else if (a >= c && c >= b)
        {
            Console.WriteLine("{0} {1} {2}", a, c, b); //ACB
        }
        else if (b >= a && a >= c)
        {
            Console.WriteLine("{0} {1} {2}", b, a, c); //BAC
        }
        else if (b >= c && c >= a)
        {
            Console.WriteLine("{0} {1} {2}", b, c, a); //BCA
        }
        else if (c >= a && a >= b)
        {
            Console.WriteLine("{0} {1} {2}", c, a, b); //CAB
        }
        else if (c >= b && b >= a)
        {
            Console.WriteLine("{0} {1} {2}", c, b, a); //CBA
        }
    }
}
