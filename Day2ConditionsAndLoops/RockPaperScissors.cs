using System;

namespace Day2
{
    /// <summary>
    /// This class implements a 2-player Rock Paper Scissors game.
    /// Game Rules:
    /// - Rock beats Scissors
    /// - Scissors beats Paper
    /// - Paper beats Rock
    /// - Same choices result in a Tie
    /// Players must enter: Rock, Paper, or Scissors (case-insensitive)
    /// </summary>
    public class RockPaperScissors
    {
        #region Functionality
        public static void PlayGame()
        {
            #region Declarations
            string player1Choice, player2Choice;
            #endregion

            #region Code Functionality
            // Get Player 1 choice
            Console.Write("Player 1, enter your choice (Rock/Paper/Scissors): ");
            player1Choice = Console.ReadLine().ToLower();

            // Get Player 2 choice
            Console.Write("Player 2, enter your choice (Rock/Paper/Scissors): ");
            player2Choice = Console.ReadLine().ToLower();

            Console.WriteLine("\n--- Game Result ---");
            Console.WriteLine($"Player 1 chose: {player1Choice}");
            Console.WriteLine($"Player 2 chose: {player2Choice}");
            Console.WriteLine();

            // Determine winner using nested conditionals
            if (player1Choice == player2Choice)
            {
                Console.WriteLine("It's a TIE!");
            }
            else if (player1Choice == "rock")
            {
                if (player2Choice == "scissors")
                {
                    Console.WriteLine("Player 1 WINS! Rock beats Scissors.");
                }
                else if (player2Choice == "paper")
                {
                    Console.WriteLine("Player 2 WINS! Paper beats Rock.");
                }
                else
                {
                    Console.WriteLine("Invalid choice by Player 2!");
                }
            }
            else if (player1Choice == "paper")
            {
                if (player2Choice == "rock")
                {
                    Console.WriteLine("Player 1 WINS! Paper beats Rock.");
                }
                else if (player2Choice == "scissors")
                {
                    Console.WriteLine("Player 2 WINS! Scissors beats Paper.");
                }
                else
                {
                    Console.WriteLine("Invalid choice by Player 2!");
                }
            }
            else if (player1Choice == "scissors")
            {
                if (player2Choice == "paper")
                {
                    Console.WriteLine("Player 1 WINS! Scissors beats Paper.");
                }
                else if (player2Choice == "rock")
                {
                    Console.WriteLine("Player 2 WINS! Rock beats Scissors.");
                }
                else
                {
                    Console.WriteLine("Invalid choice by Player 2!");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice by Player 1!");
            }
            #endregion
        }
        #endregion
    }
}
