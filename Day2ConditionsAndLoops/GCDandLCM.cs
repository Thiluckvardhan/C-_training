using System;

namespace Day2
{
    /// <summary>
    /// This class calculates the Greatest Common Divisor (GCD) and Least Common Multiple (LCM) of two numbers.
    /// GCD: The largest number that divides both numbers without remainder.
    /// LCM: The smallest number that is a multiple of both numbers.
    /// Formula: LCM(a, b) = (a * b) / GCD(a, b)
    /// </summary>
    public class GCDandLCM
    {
        #region Functionality
        /// <summary>
        /// Reads two integers and prints their GCD and LCM.
        /// </summary>
        /// <remarks>
        /// Uses the Euclidean algorithm for GCD and the product/gcd formula for LCM.
        /// </remarks>
        public static void Calculate()
        {
            #region Declarations
            int num1, num2, a, b, gcd, lcm, remainder;
            #endregion

            #region Code Functionality
            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Error: Please enter positive numbers!");
                return;
            }

            a = num1;
            b = num2;

            // Calculate GCD using Euclidean algorithm
            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            gcd = a;

            // Calculate LCM using formula
            lcm = (num1 * num2) / gcd;

            Console.WriteLine($"\nGCD of {num1} and {num2} is: {gcd}");
            Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
            #endregion
        }
        #endregion
    }
}
