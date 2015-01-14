/*
    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
 */

using System;

class HexToDec
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long decNum = 0;


        long digit = 0,
            power = 1;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            switch (hex[i])
            {
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
                default: digit = (int)hex[i] - 48; break;
            }
            decNum += digit * power;
            power *= 16;
        }
        Console.WriteLine(decNum);
    }
}