/*
    ite a program that reads two positive integer numbers and prints how many numbers p exist between them
    such that the reminder of the division by 5 is 0.
 */
using System;

class NumsDividableByGivenNum
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine()),
            endNum = int.Parse(Console.ReadLine()),
            p = 0;

        for (int i = startNum; i <= endNum; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0}, ", i);
                p++;
            }
        }
        Console.WriteLine("\r\n{0} numbers found.", p);
    }
}