using System;
using System.Globalization;

namespace Day1
{
    class Primecheck
{
    public static void check()
    {
        int n =int.Parse(Console.ReadLine());
        Console.Write("2 ");
        for (int i = 3; i < n; i+=2)
        {
            bool a = true;
            for (int j = 3; j <=Math.Sqrt(i); j+=2)
            {
                if (i % j == 0)
                {
                    a = false;
                    break;
                }
            }
            if (a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
}
