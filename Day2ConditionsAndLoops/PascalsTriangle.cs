using System;

namespace Day2
{
    /// <summary>
    /// This class prints Pascal's Triangle up to N rows using nested loops.
    /// Pascal's Triangle: Each number is the sum of the two numbers directly above it.
    /// Properties: Binomial coefficients, each row represents powers of 11.
    /// </summary>
    public class PascalsTriangle
    {
        #region Functionality
        public static void PrintTriangle()
        {
            #region Declarations
            int rows, coefficient;
            #endregion

            #region Code Functionality
            Console.Write("Enter number of rows for Pascal's Triangle: ");
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

            Console.WriteLine("\nPascal's Triangle:");
            
            for (int i = 0; i < rows; i++)
            {
                // Print leading spaces for formatting
                for (int space = 0; space < rows - i; space++)
                {
                    Console.Write(" ");
                }

                coefficient = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(coefficient + " ");
                    coefficient = coefficient * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
            #endregion
        }
        #endregion
    }
}
