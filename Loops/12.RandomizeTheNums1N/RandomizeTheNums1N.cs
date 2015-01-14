// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Linq;

class RandomizeTheNums1N
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n + 1];
        Random Generator = new Random();

        for (int i = 1; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }

        numbers = numbers.OrderBy(t => Generator.Next()).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != 0)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}