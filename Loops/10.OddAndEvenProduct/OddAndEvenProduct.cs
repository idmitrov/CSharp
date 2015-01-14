/*
    u are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */

using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] userInput = n.Split(' ');
        int[] numbers = Array.ConvertAll(userInput, int.Parse);
        int odd = 1,
            even = 1;

        for (int i = 0; i < numbers.Length; i += 2)
        {
            odd *= numbers[i];
            if (i + 1 < numbers.Length)
            {
                even *= numbers[i + 1];
            }
        }
        if (numbers.Length < 2)
        {
            Console.WriteLine("Invalid input!");
        }
        else if (odd == even)
        {
            Console.WriteLine("Yes\r\nproduct = {0}", even);
        }
        else
        {
            Console.WriteLine("No\r\nodd_product = {0}\r\neven_product = {1}", odd, even);
        }
    }
}

