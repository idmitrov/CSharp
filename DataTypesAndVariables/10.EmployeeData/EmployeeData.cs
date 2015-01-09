/*
     A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
    Use descriptive names. Print the data at the console.
 
 */

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Pesho",
               lastName = "Goshev";
        byte age = 25;
        char gender = 'm';
        decimal personalID = 8306112507M,
                UniqEmpNumber = 27560000M;
        
        //UNCOMENT TO WORK
        //Console.Write("First name: ");
        //string firstName = Console.ReadLine();
        //Console.Write("Last name: ");
        //string lastName = Console.ReadLine();
        //Console.Write("Age: ");
        //byte age = byte.Parse(Console.ReadLine());
        //Console.Write("Gender(m/f): ");
        //char gender = char.Parse(Console.ReadLine());
        //Console.Write("Personal ID: ");
        //decimal personalID = decimal.Parse(Console.ReadLine());
        //Console.Write("Unique employee number: ");
        //decimal UniqEmpNumber = decimal.Parse(Console.ReadLine());
        //RESULT
        Console.WriteLine("Employee data information:");
        Console.WriteLine("Name: {0} {1}\r\nAge: {2}\r\nGender: {3}\r\nPersonal ID: {4}\r\nUnique employee number: {5}",
                          firstName, lastName, age, gender, personalID, UniqEmpNumber);
    }
}
