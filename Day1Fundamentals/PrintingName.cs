using System;

namespace Day1
{
    class PrintingName
{
    public static void name()
    {
        Console.WriteLine("Enter your name: ");
        string? name= Console.ReadLine();
        Console.WriteLine("Hello, "+name+ "!");
    }
}
}
