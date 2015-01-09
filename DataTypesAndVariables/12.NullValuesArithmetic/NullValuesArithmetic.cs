/*
    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
 */

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int ? firstNumber = null;
        double ? secondNumber = null;
        Console.WriteLine(firstNumber + secondNumber);
        firstNumber += 1;
        Console.WriteLine(firstNumber);
        secondNumber += 1;
        Console.WriteLine(firstNumber + secondNumber);
        // RESULT NULL + ANYTHING == NULL,
        // or with few words NOTHING + 10 = 10 NOTHING's, WHICH ARE AGAIN NOTHING!
    }
}
