using System;
using System.Globalization;

namespace Day1
{
    /// <summary>
    /// Generates and prints prime numbers up to a given limit.
    /// </summary>
    class Primecheck
{
    /// <summary>
    /// Reads an integer limit from the console and prints primes less than the limit.
    /// </summary>
    /// <remarks>
    /// Uses trial division up to √n, skipping even numbers for efficiency.
    /// </remarks>
    public static void check()
    {
        #region Variables
        // Upper limit for prime generation
        int n = int.Parse(Console.ReadLine());
        // Current candidate number (odd numbers starting from 3)
        int i;
        // Flag to track primality for the current candidate
        bool a;
        #endregion

        #region Method Logic
        // Handle the smallest prime
        Console.Write("2 ");
        // Iterate over odd candidates and test for primality
        for (i = 3; i < n; i += 2)
        {
            a = true;
            for (int j = 3; j <= Math.Sqrt(i); j += 2)
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
        #endregion
    }
}
}
