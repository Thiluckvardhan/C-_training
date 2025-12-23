using System;

namespace Day2
{
    /// <summary>
    /// This class displays the first N terms of the Fibonacci sequence.
    /// Fibonacci sequence: Each number is the sum of the two preceding ones.
    /// Example: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...
    /// </summary>
    public class FibonacciSeries
    {
        #region Functionality
        public static void DisplaySeries()
        {
            #region Declarations
            int n, first, second, next;
            #endregion

            #region Code Functionality
            Console.Write("Enter the number of terms: ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            if (n <= 0)
            {
                Console.WriteLine("Error: Please enter a positive number!");
                return;
            }

            first = 0;
            second = 1;

            Console.WriteLine($"\nFirst {n} terms of Fibonacci series:");
            
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    next = i;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.Write(next + " ");
            }
            Console.WriteLine();
            #endregion
        }
        #endregion
    }
}
