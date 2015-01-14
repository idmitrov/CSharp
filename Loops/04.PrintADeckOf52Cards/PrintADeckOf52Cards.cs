using System;
using System.Text;

class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string clubs = "\u2660",
               diamonds = "\u2666",
               hearts = "\u2665",
               spades = "\u2663";

        for (int i = 2; i <= 10; i++)
        {
            Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}\r\n", i, spades, diamonds, hearts, clubs);
        }
        for (int i = 1; i < 5; i++)
        {
            switch (i)
            {
                case 1:
                {
                    string j = "J";
                    Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}\r\n", j, spades, diamonds, hearts, clubs);
                    break;
                }
                case 2:
                {
                    string q = "Q";
                    Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}\r\n", q, spades, diamonds, hearts, clubs);
                    break;
                }
                case 3:
                {
                    string k = "K";
                    Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}\r\n", k, spades, diamonds, hearts, clubs);
                    break;
                }
                case 4:
                {
                    string a = "A";
                    Console.Write("{0}{1} {0}{2} {0}{3} {0}{4}\r\n", a, spades, diamonds, hearts, clubs);
                    break;
                }
            }
        }

    }
}
