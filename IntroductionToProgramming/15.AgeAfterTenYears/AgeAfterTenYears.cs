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
            int age = (crntDT.Year - userBday.Year) - 1;

            if (crntDT.Month >= userBday.Month && crntDT.Day >= userBday.Day)
            {
                age++;
            }
            Console.WriteLine("You are {0} years old.", age);
            int ageInTenYears = age + 10;
            Console.WriteLine("You will be {0} years old in 10 years.", ageInTenYears);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Date");
        }
    }
}

        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Date");
        }
    }
}
