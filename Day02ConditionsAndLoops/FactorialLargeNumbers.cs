using System;
using System.Numerics;

namespace Day2
{
    /// <summary>
    /// This class calculates N factorial and handles potential overflow for larger integers.
    /// Uses BigInteger to handle very large numbers that exceed standard integer limits.
    /// Factorial: N! = N * (N-1) * (N-2) * ... * 2 * 1
    /// Example: 5! = 5 * 4 * 3 * 2 * 1 = 120
    /// </summary>
    public class FactorialLargeNumbers
    {
        #region Functionality
        /// <summary>
        /// Reads an integer from the console and prints its factorial using BigInteger.
        /// </summary>
        /// <remarks>
        /// Validates input and handles non-negative numbers; outputs factorial value and digit count.
        /// </remarks>
        public static void CalculateFactorial()
        {
            #region Declarations
            int n;
            BigInteger factorial;
            #endregion

            #region Code Functionality
            Console.Write("Enter a number to calculate factorial: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            if (n < 0)
            {
                Console.WriteLine("Error: Factorial is not defined for negative numbers!");
                return;
            }

            factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"\n{n}! = {factorial}");
            Console.WriteLine($"Number of digits: {factorial.ToString().Length}");
            #endregion
        }
        #endregion
    }
}
