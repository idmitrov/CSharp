/*
    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).

 * NOTICE!!!
    The number has always exactly 4 digits and cannot start with 0.
 */


using System;

class FourDigitNumber
{
    static void Main()
    {
        string input = Console.ReadLine();

        int firstDigit = 0;

        if (int.TryParse(input[0].ToString(), out firstDigit))
        {

            if (firstDigit != 0)
            {
                int n = int.Parse(input);

                if (n > 999 && n < 10000)
                {
                    int a = n / 1000,
                    b = n / 100 % 10,
                    c = n / 10 % 10,
                    d = n % 10,
                    sumOfDigits = a + b + c + d;

                    Console.WriteLine("Sum of digits: {0}", sumOfDigits);
                    Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
                    Console.WriteLine("Last digit in first position: {0}{1}{2}{3}", d, a, b, c);
                    Console.WriteLine("Exchange second and third digit: {0}{1}{2}{3}", a, c, b, d);
                }
                else
                {
                    Console.WriteLine("The number must contain exactly 4 digits!");
                }
            }
            else
            {
                Console.WriteLine("The number can not start with 0");
            }
        }
        else
        {
            Console.WriteLine("Invald input");
        }
    }
}
