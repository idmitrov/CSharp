/*
    A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
 */
using System;

class BeerTime
{
    static void Main()
    {
        DateTime now = default(DateTime);
        //IF PARSE SUCCESSFUL
        if (DateTime.TryParse(Console.ReadLine(), out now))
        {
            int hours = now.Hour;
            //IF HOUR IS BETWEEN 3:00AM AND 12:59PM
            if (hours < 13 && hours >= 3)
            {
                Console.WriteLine("none-beer time");
            }
            //ELSE HOUR IS BETWEEN 1PM AND 2:59AM
            else
            {
                Console.WriteLine("beer time");
            }
        }
        //ELSE PARSE NOT SUCCESSFULL
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}