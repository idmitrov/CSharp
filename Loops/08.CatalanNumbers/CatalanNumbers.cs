
using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        if (n > 0 && n < 100)
        {
            BigInteger num = 1,
                       denom = 1,
                       result = 1;

            for (int k = 2; k <= n; k++)
            {
                num *= (n + k);

                if (num % k == 0)
                {
                    num /= k;
                }
                else
                {
                    denom *= k;
                }
            }

            result = num / denom;
            Console.WriteLine(result);
        }
    }
}
