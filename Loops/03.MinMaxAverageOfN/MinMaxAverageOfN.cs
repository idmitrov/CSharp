/*
    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
 */
using System;
using System.Linq;

class MinMaxAverageOfN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()),
            sum = 0;
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] += int.Parse(Console.ReadLine());
            sum += nums[i];
        }
        double avg = sum / (double)n;
        Console.WriteLine("Min: {0}", nums.Min());
        Console.WriteLine("Max: {0}", nums.Max());
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Avg: {0:0.00}", avg);
    }
}
