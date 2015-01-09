
/*
    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values 
    by using some programming logic.
    Print the variable values before and after the exchange.
 */

using System;

class EchangeVariableValues
{
    static void Main()
    {
        int a = 5,
            b = 10;
        Console.WriteLine("BEFORE EXCHANGING a = {0}", a);
        Console.WriteLine("BEFORE EXCHANGING b = {0}\r\n", b);

        a += b;
        b = a - b;
        a -= b;

        Console.WriteLine("AFTER EXCHANFING a = {0}", a);
        Console.WriteLine("AFTER EXCHANGING b = {0}\r\n", b);

        //USING 3RD VARIABLE TO BACKUP a VALUE
        //int a = 5,
        //    b = 10
        //    c = 5;
        
        //a = b;
        //b = c;
    }
}
