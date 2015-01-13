// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine()),
            mask = 7,
            firstBits = (mask << 3 & n) >> 3,
            secondBits = (mask << 24 & n ) >> 24;

        n = ~(mask << 3) & n;
        n = ~(mask << 24) & n;
        n = firstBits << 24 | n;
        n = secondBits << 3 | n;
        Console.WriteLine(n);
    }
}