/*
    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
 */

using System;

class BinToDec
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] inputAsBin = new int[input.Length];
        long decNum = 0,
             multyplier = 1;

        for (int i = 0; i < inputAsBin.Length; i++)
        {
            inputAsBin[i] = int.Parse(input[i].ToString());
        }
        Array.Reverse(inputAsBin);

        foreach (var digit in inputAsBin)
        {
            decNum += digit * multyplier;
            multyplier *= 2;
        }
        Console.WriteLine(decNum);
    }
}