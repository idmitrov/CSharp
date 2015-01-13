/*
     We are given an integer number n, a bit value v (v=0 or 1) and a position p.
     Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
     from the binary representation of n while preserving all other bits in n.
 */

using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Bit position: ");
        int pos = int.Parse(Console.ReadLine());
        Console.Write("Bit value: ");
        int value = int.Parse(Console.ReadLine());
        uint mask = 1;

        if (value == 0) // USING & (AND) - 1 & 0 = 0 | 0 & 1 = 0 | 1 & 1 = 1;
        {
            n = ~(mask << pos) & n; //~mask USING operator ~ (NOT) means if mask = 1, ~mask = 0; if mask = 0; ~mask = 1;
        }
        else //ELSE USING | (OR)
        {
            n = mask << pos | n;
        }
        Console.WriteLine(n);

    }
}