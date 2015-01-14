// ite a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].

using System;

class RandomNumsInRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()),
            min = int.Parse(Console.ReadLine()),
            max = int.Parse(Console.ReadLine());
        Random randominator = new Random();

        Console.Clear();
        for (int i = n; i > 0; i--)
        {
            Console.Write("{0} ", randominator.Next(min, max));
        }
        Console.WriteLine();
    }
}


