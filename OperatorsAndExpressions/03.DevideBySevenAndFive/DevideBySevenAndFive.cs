//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DevideBySevenAndFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        //USING ? OPERATOR
        Console.WriteLine(number % 5 == 0 && number % 7 == 0 ? true : false);

        //USING IF ELSE
        //bool isDivisible = false;
        //if (number % 5 == 0 && number % 7 == 0)
        //{
        //    isDivisible = true;
        //}
        //Console.WriteLine(isDivisible);
    }
}
