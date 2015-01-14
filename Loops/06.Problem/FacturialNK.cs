// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).Use only one loop.

using System;
using System.Numerics;

class FacturialNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()),
            k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1,
                   kFactorial = 1;

        if (k > 1 && k < n && n < 100)
        {
            for (int i = n; i > 0; i--)
            {
                nFactorial *= n--;
                kFactorial *= k;
                if (k > 1)
                {
                    k--;
                }
            }
            Console.WriteLine("N! / K! = {0}", nFactorial / kFactorial);
        }
        else
        {
            Console.WriteLine("Invalid input \r\n(1 < k < n < 100)");
        }
    }
}

