/*
     A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
     bank name, IBAN, 3 credit card numbers associated with the account.
     Declare the variables needed to keep the information for a single bank account 
     using the appropriate data types and descriptive names.
 */

using System;

class BankAccountData
{
    static void Main()
    {
        //NAME
        string firstName = "Pesho",
               middleName = "Georgiev",
               lastName = "Ivanov";
        //AVAILABLE AMOUNT OF MONEY
        decimal balance = 9999.0000009M;
        //BANK INFO
        string bankName = "CodersBank",
               iban = "BG-09-123-321-123-321",
            //CREDIT CARDS NUMBERS
               fisaGold = "651-249-761-2309",
               fisaSilver = "908-712-376-7342",
               fisaVIP = "123-231-312-3123";

        Console.WriteLine("Account Holder {0} {1} {2}\r\n", firstName , middleName, lastName);
        Console.WriteLine("Available amount of money: {0}\r\n", balance);
        Console.WriteLine("{0} , iban - {1}\r\n\r\nCredit cards:\r\n", bankName, iban);
        Console.WriteLine("Fisa Electron GOLD: {0}", fisaGold);
        Console.WriteLine("Fisa Electron SILVER: {0}", fisaSilver);
        Console.WriteLine("Fisa Electron VIP: {0}", fisaVIP);
    }
}
