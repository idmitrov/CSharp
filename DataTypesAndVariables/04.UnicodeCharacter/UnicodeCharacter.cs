/*
 Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax,
 and then print it.
 Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *
 */

using System;

class UnicodeCharacter
{
    static void Main()
    {
        char star = '\u002A';
        Console.WriteLine(star);

        //FIND DEC VALUE OF 42 = 2A, THEN ADD \u00 + 2A = \u002A = character '*'
        //Console.WriteLine("{0:X}", 42);
    }
}
