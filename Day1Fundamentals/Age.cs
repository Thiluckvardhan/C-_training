using System;

/// <summary>
/// Provides age-based eligibility check for drinking.
/// Reads user input from the console and outputs eligibility status.
/// </summary>
namespace Day1
{
    /// <summary>
    /// Contains methods to evaluate age for drinking eligibility.
    /// </summary>
    class Age
    {
        /// <summary>
        /// Reads age from console and prints whether the user is eligible to drink.
        /// </summary>
        /// <remarks>
        /// This method does not accept parameters; it reads input from the console.
        /// </remarks>
        public static void age()
        {
            #region Variable Declarations
            // Read the user's input from the console (expected to be age in years)
            string? input = Console.ReadLine();
            #endregion

            #region Method Logic
            // Validate the input and convert it to an integer age value
            if (int.TryParse(input, out int age))
            {
                // Check legal drinking age threshold (18 years used here)
                if (age >= 18)
                {
                    Console.Write("you are eligible to drink");
                }
                else
                {
                    Console.Write("you are not eligible to drink");
                }
            }
            else
            {
                // Inform the user that the provided input is not a valid number
                Console.Write("Invalid input");
            }
            #endregion
        }
    }
}