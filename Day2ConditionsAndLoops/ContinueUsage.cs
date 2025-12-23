using System;

namespace Day2
{
    /// <summary>
    /// This class prints numbers from 1 to 50, but skips all multiples of 3 using continue statement.
    /// Demonstrates the use of continue to skip specific iterations in a loop.
    /// </summary>
    public class ContinueUsage
    {
        #region Functionality
        /// <summary>
        /// Prints numbers from 1 to 50, skipping multiples of 3 using 'continue'.
        /// </summary>
        /// <remarks>
        /// No parameters are accepted; outputs are written to the console.
        /// </remarks>
        public static void PrintNumbers()
        {
            #region Declarations
            int count;
            #endregion

            #region Code Functionality
            Console.WriteLine("Printing numbers from 1 to 50 (skipping multiples of 3):\n");

            count = 0;
            for (int i = 1; i <= 50; i++)
            {
                // Skip multiples of 3
                if (i % 3 == 0)
                {
                    continue;
                }

                Console.Write(i + " ");
                count++;

                // Print new line after every 10 numbers for better readability
                if (count % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"\n\nTotal numbers printed: {count}");
            #endregion
        }
        #endregion
    }
}
