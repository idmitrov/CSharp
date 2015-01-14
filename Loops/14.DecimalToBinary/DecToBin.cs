/*
    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
 */

using System;

class DecToBin
{
    static void Main()
    {
        long decNum = long.Parse(Console.ReadLine()),
             bitNum = 0;
        string binary = string.Empty;

        for (int i = 31; i >= 0; i--)
        {
            bitNum = decNum >> i;
            binary = Convert.ToBoolean(bitNum & 1) ? "1 " : "0 ";
            Console.Write(binary);
        }
        Console.WriteLine();
    }
}