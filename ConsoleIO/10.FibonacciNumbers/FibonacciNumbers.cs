/*
    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
    (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 */

using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            BigInteger first = 0,
                       second = 1,
                       third = 0;

            Console.Write("{0}, ", first);
            Console.Write("{0}, ", second);

            for (int i = 2; i < n; i++)
            {
                third = first + second;
                Console.Write("{0}, ", third);
                first = second;
                second = third;
            }
        }
    }
}