// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Height: ");
        int height = int.Parse(Console.ReadLine()),
            perimeter = (width * 2) + (height * 2), // () are not required in this case, but the code reading is easier this way.
            area = width * height;
        Console.WriteLine("Perimeter: {0}", perimeter);
        Console.WriteLine("Area: {0}", area);

    }
}
