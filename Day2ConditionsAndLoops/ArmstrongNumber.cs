using System;

namespace Day2
{
    /// <summary>
    /// This class checks if a number is an Armstrong number.
    /// Armstrong Number: A number equals the sum of its digits raised to the power of number of digits.
    /// Example: 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
    /// </summary>
    public class ArmstrongNumber
    {
        #region Functionality
        public static void CheckArmstrong()
        {
            #region Declarations
            int number, originalNumber, remainder, sum, digits;
            #endregion

            #region Code Functionality
            Console.Write("Enter a number to check if it's an Armstrong number: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            originalNumber = number;
            sum = 0;
            
            // Count number of digits
            digits = number.ToString().Length;

            // Calculate sum of digits raised to power of digit count
            while (number > 0)
            {
                remainder = number % 10;
                sum += (int)Math.Pow(remainder, digits);
                number /= 10;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an ARMSTRONG number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is NOT an Armstrong number.");
            }
            #endregion
        }
        #endregion
    }
}
