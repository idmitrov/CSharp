// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("How much numbers to sum ?: ");
        int numbers = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("number to sum: ");
            sum += double.Parse(Console.ReadLine());    
        }
        Console.WriteLine("Sum of numbers = {0}", sum);
    }
}
