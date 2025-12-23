using System;

namespace Day2
{
    /// <summary>
    /// This class reverses an integer and checks if it is a palindrome using while loop.
    /// Palindrome: A number that reads the same backward as forward.
    /// Example: 121, 12321, 1331 are palindromes.
    /// </summary>
    public class ReverseAndPalindrome
    {
        #region Functionality
        public static void CheckPalindrome()
        {
            #region Declarations
            int number, originalNumber, reversedNumber, remainder;
            #endregion

            #region Code Functionality
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            originalNumber = number;
            reversedNumber = 0;

            // Reverse the number using while loop
            while (number > 0)
            {
                remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine($"\nOriginal Number: {originalNumber}");
            Console.WriteLine($"Reversed Number: {reversedNumber}");

            if (originalNumber == reversedNumber)
            {
                Console.WriteLine($"{originalNumber} is a PALINDROME.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is NOT a palindrome.");
            }
            #endregion
        }
        #endregion
    }
}
