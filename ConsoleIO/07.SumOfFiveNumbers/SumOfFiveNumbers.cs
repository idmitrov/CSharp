// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        string[] numbers = Console.ReadLine().Split(' ');
        double sum = 0;
        foreach (string number in numbers)
        {
            sum += double.Parse(number);
        }
        Console.WriteLine(sum);
    }
}
