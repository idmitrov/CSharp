using System;
using System.Numerics;

class TrailingZeroesN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()),
            counter = 0;
        BigInteger factorialN = 1;

        for (int i = n; i > 0; i--)
        {
            factorialN *= i;
        }
        while (factorialN % 10 == 0)
        {
            factorialN /= 10;
            counter++;
        }
        Console.WriteLine(counter);
    }
}
