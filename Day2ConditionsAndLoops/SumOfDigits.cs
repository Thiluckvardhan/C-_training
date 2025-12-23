using System;

namespace Day2
{
    /// <summary>
    /// This class repeatedly sums digits of a number until the result is a single digit.
    /// Also known as Digital Root. Can be calculated using modulo 9 formula: (n-1) % 9 + 1
    /// Example: 9875 -> 9+8+7+5=29 -> 2+9=11 -> 1+1=2
    /// </summary>
    public class SumOfDigits
    {
        #region Functionality
        /// <summary>
        /// Reads a number and computes its digital root by repeatedly summing digits.
        /// </summary>
        /// <remarks>
        /// Continues until a single digit is obtained; handles negative inputs by taking absolute value.
        /// </remarks>
        public static void CalculateDigitalRoot()
        {
            #region Declarations
            int number, sum, temp;
            #endregion

            #region Code Functionality
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            if (number < 0)
            {
                number = Math.Abs(number);
                Console.WriteLine($"Using absolute value: {number}");
            }

            temp = number;
            Console.WriteLine($"\nCalculating digital root of {number}:");

            while (temp >= 10)
            {
                sum = 0;
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                Console.WriteLine($"Sum of digits: {sum}");
                temp = sum;
            }

            Console.WriteLine($"\nDigital Root: {temp}");
            #endregion
        }
        #endregion
    }
}
