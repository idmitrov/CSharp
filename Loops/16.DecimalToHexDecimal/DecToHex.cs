/*
    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
 */

using System;

class DecToHex
{
    static void Main()
    {
        long decNum = long.Parse(Console.ReadLine());
        string hexDecimal = string.Empty;

        if (decNum == 0)
        {
            hexDecimal = "0";
        }
        else
        {
            while (decNum > 0)
            {
                long digit = decNum % 16;
                decNum /= 16;

                switch (digit)
                {
                    case 10: hexDecimal = "A" + hexDecimal; break;
                    case 11: hexDecimal = "B" + hexDecimal; break;
                    case 12: hexDecimal = "C" + hexDecimal; break;
                    case 13: hexDecimal = "D" + hexDecimal; break;
                    case 14: hexDecimal = "E" + hexDecimal; break;
                    case 15: hexDecimal = "F" + hexDecimal; break;
                    default: hexDecimal = digit + hexDecimal; break;
                }
            }

        }
        Console.WriteLine(hexDecimal);
    }
}
