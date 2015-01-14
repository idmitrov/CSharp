/*
    Write a program that reads from the console a positive integer number n (1 = n = 20) 
    and prints a matrix like in the examples below. Use two nested loops.
 */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        if (n >= 1 && n <= 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n + i; j++)
                {
                    if (n > 5)
                    {
                        Console.Write("{0, 2} ", j);
                    }
                    else
                    {
                        Console.Write("{0} ", j);
                    }
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}

