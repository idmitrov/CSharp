// Write an expression that checks for given integer if its third digit from right-to-left is 7

using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n / 100 % 10 == 7 ? true : false);

        //USING IF ELSE
        //bool isSeven = false;
        //if (n / 100 % 10 == 7)
        //{
        //    isSeven = true;
        //}
        //Console.WriteLine(isSeven);
    }
}
