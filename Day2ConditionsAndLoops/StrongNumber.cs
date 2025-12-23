using System;

namespace Day2
{
    /// <summary>
    /// This class checks if a number is a Strong Number.
    /// Strong Number: A number whose sum of factorial of digits equals the number itself.
    /// Example: 145 = 1! + 4! + 5! = 1 + 24 + 120 = 145
    /// Other examples: 1, 2, 145, 40585
    /// </summary>
    public class StrongNumber
    {
        #region Functionality
        public static void CheckStrong()
        {
            #region Declarations
            int number, originalNumber, digit, sum, factorial;
            #endregion

            #region Code Functionality
            Console.Write("Enter a number to check if it's a Strong number: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            if (number < 0)
            {
                Console.WriteLine("Error: Please enter a positive number!");
                return;
            }

            originalNumber = number;
            sum = 0;

            Console.WriteLine("\nCalculation:");

            while (number > 0)
            {
                digit = number % 10;
                factorial = 1;

                // Calculate factorial of digit
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"{digit}! = {factorial}");
                sum += factorial;
                number /= 10;
            }

            Console.WriteLine($"\nSum of factorials: {sum}");

            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is a STRONG number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is NOT a Strong number.");
            }
            #endregion
        }
        #endregion
    }
}
