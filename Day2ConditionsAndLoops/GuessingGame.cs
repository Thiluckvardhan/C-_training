using System;

namespace Day2
{
    /// <summary>
    /// This class implements a guessing game using do-while loop.
    /// The user keeps guessing until they find the secret number.
    /// Provides hints (too high/too low) after each incorrect guess.
    /// </summary>
    public class GuessingGame
    {
        #region Functionality
        /// <summary>
        /// Runs the interactive number guessing game until the correct number is guessed.
        /// </summary>
        /// <remarks>
        /// Generates a random number between 1 and 100 and provides hints after each guess.
        /// </remarks>
        public static void PlayGame()
        {
            #region Declarations
            int secretNumber, userGuess, attempts;
            string input;
            #endregion

            #region Code Functionality
            // Generate random secret number between 1 and 100
            Random random = new Random();
            secretNumber = random.Next(1, 101);
            attempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Try to guess it!\n");

            do
            {
                Console.Write("Enter your guess: ");
                input = Console.ReadLine();

                if (!int.TryParse(input, out userGuess))
                {
                    Console.WriteLine("Error: Please enter a valid number!");
                    continue;
                }

                attempts++;

                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.\n");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.\n");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed it!");
                    Console.WriteLine($"The number was {secretNumber}");
                    Console.WriteLine($"It took you {attempts} attempts.");
                }

            } while (userGuess != secretNumber);
            #endregion
        }
        #endregion
    }
}
