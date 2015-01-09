/*
 Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

   ©

  © ©

 ©   ©

© © © ©
 
 */
using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine(@"   ©

  © ©

 ©   ©

© © © ©");

        //char copy = '\u00A9';
        //string space = " ";
        //Console.WriteLine(space + space + space + copy);
        //Console.WriteLine();
        //Console.WriteLine(space + space + copy + space + copy);
        //Console.WriteLine();
        //Console.WriteLine(space + copy + space + space + space + copy);
        //Console.WriteLine();
        //Console.WriteLine(copy + space + copy + space + copy + space + copy);


        //CAN BE USED LOOP ALSO AND WILL BE MUCH BETTER IF USE IT FOR UKNOWN TRIANGLE AREA
    }
}
