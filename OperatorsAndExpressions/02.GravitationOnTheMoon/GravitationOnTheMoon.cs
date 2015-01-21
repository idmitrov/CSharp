/*
     The gravitational field of the Moon is approximately 17% of that on the Earth.
     Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

using System;
using System.Threading;
using System.Globalization;

class GravitationOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double weight = double.Parse(Console.ReadLine().Replace(",", ".")),
               gravityDiff = 0.17,
               weightOnTheMoon = weight * gravityDiff;

        Console.WriteLine(weightOnTheMoon);

    }
}
