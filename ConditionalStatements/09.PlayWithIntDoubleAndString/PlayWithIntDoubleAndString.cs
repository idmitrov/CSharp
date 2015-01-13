/*
    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    If the variable is int or double, the program increases it by one.
    If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
 */

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type\r\n1 --> int\r\n2 --> double\r\n3 --> string");

        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                Console.Write("Please enter a integer: ");
                int intValue = int.Parse(Console.ReadLine());
                Console.WriteLine(intValue + 1);
                break;
            case "2":
                Console.Write("Please enter a double: ");
                double doubleValue = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleValue + 1);
                break;
            case "3":
                Console.Write("Please enter a string:");
                string stringValue = Console.ReadLine();
                Console.WriteLine("{0}*", stringValue);
                break;
        }
    }
}