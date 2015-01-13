// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberAsWord
{
    static void Main()
    {
        int number = 0;
        bool exit = false;
        string[] top20 = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "ten", "Eleven", "Twelve", "Thirteen", "Forteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty" };
        string[] top100 = { "zero", "ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "Hundred" };

        while (exit == false)
        {
            Console.Write("Type a number: ");
            bool parseSuccess = int.TryParse(Console.ReadLine(), out number);
            if (parseSuccess && number >= 0 && number <= 999)
            {
                for (int i = number; i <= 999; i++)
                {
                    //0 - 20
                    if (i <= 20)
                    {
                        Console.WriteLine(top20[i]);
                        break;
                    }
                    //21 - 99
                    if (i >= 21 && i <= 99)
                    {
                        if (i % 10 == 0)
                        {
                            Console.WriteLine(top100[i / 10]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("{0} {1}", top100[i / 10], top20[i % 10].ToLower());
                            break;
                        }
                    }
                    //100 - 999
                    try
                    {   //x11 - x20 WHERE X IS: 100 - 900
                        if (i >= 100 && i <= 999)
                        {
                            if (i % 100 == 0)//100, 200, 300...900
                            {
                                Console.WriteLine("{0} hundred", top20[i / 100]);
                                break;
                            }
                            else//101, 203, 404...999
                            {
                                Console.WriteLine("{0} hundred and {1}", top20[i / 100], top20[i % 100].ToLower());
                                break;
                            }
                        }
                    }
                    //x20 - 999 WHERE X IS: 100 - 900
                    catch
                    {
                        Console.WriteLine("{0} hundred and {1} {2}", top20[i / 100], top100[i % 100 / 10].ToLower(), top20[i % 10].ToLower());
                        break;
                    }
                }
            }
            else
            //ELSE NUMBER PARSE IS NOT SUCCESSFUL
            {
                Console.WriteLine("Wrong input");
                exit = true;
            }
        }
    }
}
