/*
 Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort value1 = 52130;
        sbyte value2 = -115;
        int value3 = 4825932;
        byte value4 = 97;
        short value5 = -10000;

        Console.WriteLine("ushort {0}", value1);
        Console.WriteLine("sbyte {0}", value2);
        Console.WriteLine("int {0}", value3);
        Console.WriteLine("byte {0}", value4);
        Console.WriteLine("short {0}", value5);

        //Console.WriteLine("ushort {0}\r\nsbyte{1}\r\nint {2}\r\nbyte {3}\r\nshort {4}", value1, value2, value3, value4, value5);
    }
}
