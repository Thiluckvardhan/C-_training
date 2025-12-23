using System;

namespace Day2
{
    /// <summary>
    /// This class converts a binary number string to decimal without using built-in conversion functions.
    /// Binary: Base-2 number system using only 0 and 1.
    /// Conversion: Each digit is multiplied by 2 raised to its position power.
    /// Example: 1011 = 1*2^3 + 0*2^2 + 1*2^1 + 1*2^0 = 8 + 0 + 2 + 1 = 11
    /// </summary>
    public class BinaryToDecimal
    {
        #region Functionality
        /// <summary>
        /// Reads a binary string from the console and prints its decimal equivalent.
        /// </summary>
        /// <remarks>
        /// Validates that the input contains only '0' and '1'; computes value from right to left.
        /// </remarks>
        public static void Convert()
        {
            #region Declarations
            string binary;
            int decimalValue, baseValue, length;
            #endregion

            #region Code Functionality
            Console.Write("Enter a binary number: ");
            binary = Console.ReadLine();

            // Validate binary input
            foreach (char c in binary)
            {
                if (c != '0' && c != '1')
                {
                    Console.WriteLine("Error: Invalid binary number! Only 0 and 1 are allowed.");
                    return;
                }
            }

            decimalValue = 0;
            baseValue = 1;
            length = binary.Length;

            // Convert from right to left
            for (int i = length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    decimalValue += baseValue;
                }
                baseValue *= 2;
            }

            Console.WriteLine($"\nBinary: {binary}");
            Console.WriteLine($"Decimal: {decimalValue}");
            #endregion
        }
        #endregion
    }
}
