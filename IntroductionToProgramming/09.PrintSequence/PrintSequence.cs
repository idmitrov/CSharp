//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 1; i < 12; i++)
        {
            Console.Write("{0}{1}", i % 2 == 0 ? i : -i
                , i < 11 ? ", " : Environment.NewLine);
        }

        //STATIC WAY
        //Console.WriteLine("-1, 2, -3, 4, -5, 6, -7, 8, -9, 10, -11");
    }
}
