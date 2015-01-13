/*
     Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
     The bits are counted from right to left, starting from bit #0.
     The result of the expression should be either 1 or 0.
 */

using System;

class ExtractBit3
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine()),
             mask = 1,
             bitAtThirdPos = (mask << 3 & n) >> 3;
        Console.WriteLine(bitAtThirdPos);
    }
}
