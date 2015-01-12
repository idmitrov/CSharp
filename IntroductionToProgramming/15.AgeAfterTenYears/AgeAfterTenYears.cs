/*
 Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */

using System;
using System.Globalization;
using System.Threading;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Type your birthday in format (dd.MM.yyyy): ");
        string userInput = Console.ReadLine(),
               format = "dd.MM.yyyy";

        try
        {
            DateTime userBday = DateTime.ParseExact(userInput, format, CultureInfo.InvariantCulture);
            DateTime crntDT = DateTime.Now;
            int age = crntDT.Month >= userBday.Month && crntDT.Day >= userBday.Day ?
                crntDT.Year - userBday.Year : crntDT.Year - userBday.Year - 1;

            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("You will be {0} years old in 10 years.", age+=10);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Date");
        }
    }
}
