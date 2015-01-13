/*
    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.
 */

using System;

class MultyplicationSign
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine('0');
        }
        else
        {
            if (a < 0 && b < 0 && c > 0 ||
                a < 0 && c < 0 && b > 0 ||
                b < 0 && c < 0 && a > 0 ||
                a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine('+');
            }
            else
            {
                Console.WriteLine('-');
            }
        }
    }
}
