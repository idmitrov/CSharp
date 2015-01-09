/*
 Write a program to print the numbers 1, 101 and 1001, each at a separate line.
Name the program correctly.
 */

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine(1 + "\r\n" + 101 + "\r\n" + 1001);

        //STRING
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine("1{0}{1}", new string('0', i), i < 2 ? new string('1', i) : new string('1', i - 1));
        //}

        //INT
        //for (int i = 1; i <= 1001; i += 100)
        //{
        //    if (i / 100 % 10 < 2)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
