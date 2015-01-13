/*
     A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
     Write a program that reads the information about a company and its manager and prints it back on the console.
*/
using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("FAX number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Web site: ");
        string companyWeb = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        if (companyName == "" || companyAddress == "" || companyPhone == "" || managerFName == "" || managerLName == "" || managerPhone == "")
        {
            Console.WriteLine("All inputs are required except: Company web site and FAX");
        }
        else
        {
            //COMPANY INFO
            Console.WriteLine("\r\n{0}\r\nAddress: {1}\r\nTel. {2}\r\nFax number: {3}\r\nWeb site: {4}",
                companyName, companyAddress, companyPhone, companyFax == "" ? "(no fax)" : companyFax, companyWeb == "" ? "(no web)" : companyWeb);
            //MANAGER INFO
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})\r\n", managerFName, managerLName, managerAge, managerPhone);
        }
    }
}
