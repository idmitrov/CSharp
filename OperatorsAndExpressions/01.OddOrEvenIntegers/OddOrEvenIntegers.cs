// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //USING ? OPERATOR
        Console.WriteLine(n % 2 == 0 ? true : false);

        //USING IF ELSE
        //bool isOdd = true;
        //if (n % 2 == 0)
        //{
        //    isOdd = false;
        //}
        //Console.WriteLine(isOdd);
    }
}
