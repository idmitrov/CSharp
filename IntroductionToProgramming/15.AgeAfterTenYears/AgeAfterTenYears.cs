//  Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
using System.Globalization;
using System.Threading;

class AgeAfterTenYears
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        Console.Write("Type your birthday in format (dd.MM.yyyy): ");
        string userInput = Console.ReadLine();
        DateTime bday = default(DateTime);

        if (DateTime.TryParse(userInput, out bday) && userInput.Length > 7)
        {
            DateTime today = DateTime.Now;
            int age = today.Month >= bday.Month && today.Day >= bday.Day ? today.Year - bday.Year : today.Year - bday.Year - 1;

            Console.WriteLine("Your age: {0}", age);
            Console.WriteLine("Your age in 10 years: {0}", age + 10);
        }
        else
        {
            Console.WriteLine("Error: {0} is not valid DateTime format!", userInput);
        }
    }
}
