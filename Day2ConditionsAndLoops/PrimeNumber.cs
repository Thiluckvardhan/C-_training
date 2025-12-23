using System;

namespace Day2
{
    /// <summary>
    /// This class checks if a number is prime using a for loop and break statement.
    /// A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.
    /// </summary>
    public class PrimeNumber
    {
        #region Functionality
        public static void CheckPrime()
        {
            #region Declarations
            int number;
            bool isPrime;
            #endregion

            #region Code Functionality
            Console.Write("Enter a number to check if it's prime: ");
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Error: Invalid input!");
                return;
            }

            if (number <= 1)
            {
                Console.WriteLine($"{number} is NOT a prime number.");
                return;
            }

            isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a PRIME number.");
            }
            else
            {
                Console.WriteLine($"{number} is NOT a prime number.");
            }
            #endregion
        }
        #endregion
    }
}
