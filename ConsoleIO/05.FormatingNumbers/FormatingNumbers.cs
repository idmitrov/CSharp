/*
    Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    The number a should be printed in hexadecimal, left aligned
    Then the number a should be printed in binary form, padded with zeroes
    The number b should be printed with 2 digits after the decimal point, right aligned
    The number c should be printed with 3 digits after the decimal point, left aligned.
 */
using System;

class FormatingNumbers
{
    static void Main()
    {   //INPUT
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine()),
               c = double.Parse(Console.ReadLine());
        int width = 10;
        //OUTPUT
        if (0 <= a && a <= 500)
        {
            string firstColumn = a.ToString().PadRight(width, ' '),
                   secondColumn = Convert.ToString(a, 2).PadLeft(width, '0'),
                   thirdColumn = b.ToString("0.00").PadLeft(width, ' '),
                   lastColumn = c.ToString("0.000").PadRight(width, ' ');

            Console.WriteLine(new string(' ', 19) + "RESULT");
            Console.WriteLine(new string('-', 44));
            Console.WriteLine("{0}|{1}|{2}|{3}|", firstColumn, secondColumn, thirdColumn, lastColumn);
            Console.WriteLine(new string('-', 44));
        }
    }
}
