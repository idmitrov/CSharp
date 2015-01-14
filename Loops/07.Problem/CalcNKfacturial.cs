/*
    combinatorics, the number of ways to choose k different members out of a group of n different elements 
    (also known as the number of combinations) is calculated by the following formula: formula For example,
    there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).
    Try to use only two loops.
 */
using System;
using System.Numerics;

class CalcNKfacturial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()),
            k = int.Parse(Console.ReadLine()),
            nSubtractA = n - k;

        BigInteger facturialN = 1,
                   facturialK = 1,
                   facturialNK = 1,
                   result = 0;

        if (k > 1 && k < n && n < 100)
        {
            for (int i = n; i > 0; i--)
            {
                facturialN *= i;
                facturialK *= k;
                if (k > 1)
                {
                    k--;
                }
            }
            for (int j = nSubtractA; j > 0; j--)
            {
                facturialNK *= j;
            }
            result = facturialN / (facturialK * facturialNK);
            Console.WriteLine("n! / (k! * (n-k)!) = {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input \r\n(1 < k < n < 100)");
        }
    }
}
