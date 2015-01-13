// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class EctractBitFromInteger
{
    static void Main()
    {
        Console.Write("Type a number: ");
        uint n = uint.Parse(Console.ReadLine()),
             mask = 1;
        Console.Write("Choose position: ");
        int bitPos = int.Parse(Console.ReadLine());
        uint bitAtGivenPos = (mask << bitPos & n) >> bitPos;

        Console.WriteLine("Number = {0} | Position = {1} | Extracted bit = {2}", n, bitPos, bitAtGivenPos);
    }
}
