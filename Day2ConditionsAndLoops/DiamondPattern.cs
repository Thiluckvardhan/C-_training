using System;

namespace Day2
{
    /// <summary>
    /// This class prints a diamond pattern using asterisk (*) characters with nested loops.
    /// The diamond has both upper and lower halves, creating a symmetric pattern.
    /// Size is determined by the number of rows (must be odd for perfect diamond).
    /// </summary>
    public class DiamondPattern
    {
        #region Functionality
        public static void PrintDiamond()
        {
            #region Declarations
            int rows, i, j;
            #endregion

            #region Code Functionality
            Console.Write("Enter number of rows (odd number recommended): ");
            if (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            if (rows <= 0)
            {
                Console.WriteLine("Error: Please enter a positive number!");
                return;
            }

            Console.WriteLine("\nDiamond Pattern:");

            // Upper half (including middle)
            for (i = 1; i <= rows; i++)
            {
                // Print leading spaces
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Lower half
            for (i = rows - 1; i >= 1; i--)
            {
                // Print leading spaces
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
        }
        #endregion
    }
}
