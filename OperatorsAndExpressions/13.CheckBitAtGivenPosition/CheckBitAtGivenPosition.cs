/*
    Write a Boolean expression that returns if the bit at position p 
    (counting from 0, starting from the right) in given integer number n, has value of 1.
 */

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine()),
             mask = 1;
        int pos = int.Parse(Console.ReadLine());

        Console.WriteLine((mask << pos & n) >> pos == 1 ? true : false);

        //bool isBitOne = (mask << pos) >> pos == 1;
        //Console.WriteLine(isBitOne);
       
        //bool isOne = false;
        //if ((mask << pos & n) >> pos == 1)
        //{
        //    isOne = true;
        //}
        //Console.WriteLine(isOne);
    }
}