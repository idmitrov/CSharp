/*
     Write an expression that checks if given positive integer number n (n = 100) is prime 
     (i.e. it is divisible without remainder only to itself and 1).
 */

using System;

class PrimeCheckNumber
{
    static void Main()
    {
        Console.Write("Please enter: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        double length = Math.Sqrt(number);

        for (int i = 2; i <= length; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime);
    }
}