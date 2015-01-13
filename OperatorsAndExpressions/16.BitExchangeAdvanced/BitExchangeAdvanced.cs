//  Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
using System.Globalization;
using System.Threading;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Number n: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Bit p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Bit q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Length k: ");
        int k = int.Parse(Console.ReadLine());
        uint mask = 1;

        if (Math.Max(p, q) + k - 1 > 31)
        {
            Console.WriteLine("Out of range!");
        }
        else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            for (int i = p; i <= p + k - 1; i++, q++)
            {
                uint bitP = (n & mask << i) >> i,
                     bitQ = (n & mask << q) >> q;

                n &= ~(mask << i);
                n &= ~(mask << q);
                n = bitP << q | n;
                n = bitQ << i | n;
            }
            Console.WriteLine(n);
            Console.WriteLine("Binary: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        }
    }
}