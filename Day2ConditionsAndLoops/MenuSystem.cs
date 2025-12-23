using System;

namespace Day2
{
    /// <summary>
    /// This class implements a persistent console menu system using do-while and switch.
    /// Provides multiple options and loops until user chooses to exit.
    /// Demonstrates menu-driven programming with input validation.
    /// </summary>
    public class MenuSystem
    {
        #region Functionality
        public static void ShowMenu()
        {
            #region Declarations
            int choice;
            string input;
            bool exit;
            #endregion

            #region Code Functionality
            exit = false;

            do
            {
                Console.WriteLine("\n========== MAIN MENU ==========");
                Console.WriteLine("1. Display Welcome Message");
                Console.WriteLine("2. Calculate Square of a Number");
                Console.WriteLine("3. Check Even or Odd");
                Console.WriteLine("4. Display Current Date and Time");
                Console.WriteLine("5. Exit");
                Console.WriteLine("================================");
                Console.Write("Enter your choice (1-5): ");

                input = Console.ReadLine();

                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("\nError: Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n*** Welcome to the Console Menu System! ***");
                        break;

                    case 2:
                        Console.Write("\nEnter a number: ");
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            Console.WriteLine($"Square of {num} is: {num * num}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid number!");
                        }
                        break;

                    case 3:
                        Console.Write("\nEnter a number: ");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            Console.WriteLine($"{number} is {(number % 2 == 0 ? "EVEN" : "ODD")}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid number!");
                        }
                        break;

                    case 4:
                        Console.WriteLine($"\nCurrent Date and Time: {DateTime.Now}");
                        break;

                    case 5:
                        Console.WriteLine("\nThank you for using the menu system. Goodbye!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nError: Invalid choice! Please select 1-5.");
                        break;
                }

            } while (!exit);
            #endregion
        }
        #endregion
    }
}
