using System;

namespace Day1
{
    class Circle
{
    public static void PrintArea()
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * r * r;
        Console.WriteLine(area);
    }
}
}
