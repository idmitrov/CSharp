/*
     Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
     Note: Two floating-point numbers a and b cannot be compared directly by a == b 
     because of the nature of the floating-point arithmetic.
     Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */


using System;
using System.Threading;
using System.Globalization;

class ComparingFloats
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        decimal numberA = decimal.Parse(Console.ReadLine());
        decimal numberB = decimal.Parse(Console.ReadLine());
        decimal eps = 0.000001M;
        decimal diff = Math.Abs(numberA - numberB);
        bool areEqualAB = false;

        if (diff < eps)
        {
            areEqualAB = true;
        }
        Console.WriteLine(areEqualAB);
        Console.WriteLine(diff);
    }
}
