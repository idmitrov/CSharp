/*
 Create a console application that calculates and prints the square root of the number 12345.
Find in Internet “how to calculate square root in C#”.
 */

using System;

class SquareRootOf12345
{
    static void Main()
    {
        int number = 12345;
        double sqrtOfNumber = Math.Sqrt(number);

        Console.WriteLine("The square root of {0} is: {1}", number, sqrtOfNumber);
        Console.WriteLine("Rounded to integer number: {0}", (int)sqrtOfNumber);

    /*
    BAD WAY/LESS CODE

        Console.WriteLine("The square root of 12345 is: {0}", Math.Sqrt(12345));
        Console.WriteLine("Rounded to integer number: {0}", (int)Math.Sqrt(12345));
    */
    }
}

