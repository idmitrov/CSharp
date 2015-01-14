/*
    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
    Use only one loop. Print the result with 5 digits after the decimal point.
 */

using System;

class Calculate1PlusNFac
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()),
            k = int.Parse(Console.ReadLine());

        double sum = 1,
               factorialN = 1,
               factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            factorialK *= k;
            sum += (factorialN / factorialK);
        }
        Console.WriteLine("{0:F5}", sum);
    }
}