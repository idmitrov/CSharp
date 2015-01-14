// Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
// Use the Euclidean algorithm (find it in Internet).

using System;

class CalcGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine()),
           b = int.Parse(Console.ReadLine()),
           remain = 1;
        while (remain > 0)
        {
            remain = a % b;
            a = b;
            b = remain;
        }
        Console.WriteLine(Math.Abs(a));
    }
}