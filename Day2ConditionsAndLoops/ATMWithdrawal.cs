using System;

namespace Day2
{
    /// <summary>
    /// ATM Withdrawal Program
    /// Demonstrates nested if statements to validate:
    /// 1. Card is inserted
    /// 2. PIN is valid
    /// 3. Account balance is sufficient
    /// </summary>
    class ATMWithdrawal
    {
        public static void ATMFunctions()
        {
            #region variable declaration
            bool isCardInserted = true;
            int enteredPin = 1234;
            int correctPin = 0;
            double accountBalance = 5000;
            double withdrawalAmount = 2000;
            #endregion

            #region ATM Functionality
            if (isCardInserted)
            {
                Console.WriteLine("Card inserted successfully");

                Console.Write("Enter you Pin: ");
                int.TryParse(Console.ReadLine(),out correctPin);
                if (enteredPin == correctPin)
                {
                    Console.WriteLine("PIN is valid");


                    if (accountBalance >= withdrawalAmount)
                    {
                        accountBalance -= withdrawalAmount;
                        Console.WriteLine($"Withdrawal successful!");
                        Console.WriteLine($"Amount withdrawn: ${withdrawalAmount}");
                        Console.WriteLine($"Remaining balance: ${accountBalance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance");
                        Console.WriteLine($"Available balance: ${accountBalance}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid PIN. Transaction cancelled");
                }
            }
            else
            {
                Console.WriteLine("Please insert your card");
            }
            #endregion
        }
    }
}