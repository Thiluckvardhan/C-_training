using System;

namespace Day2
{
    /// <summary>
    /// This class implements a Simple Calculator that performs basic arithmetic operations.
    /// Operations supported: Addition (+), Subtraction (-), Multiplication (*), Division (/)
    /// Uses switch statement to determine which operation to perform based on user input.
    /// Division by zero is handled with appropriate error message.
    /// </summary>
    public class SimpleCalculator
    {
        #region Functionality
        public static void Calculate()
        {
            #region Declarations
            double num1, num2, result;
            string input;
            char operation;
            #endregion

            #region Code Functionality
            // Get first number from user
            Console.Write("Enter first number: ");
            input = Console.ReadLine();
            if (!double.TryParse(input, out num1))
            {
                Console.WriteLine("Error: Invalid number input!");
                return;
            }

            // Get operator from user
            Console.Write("Enter operator (+, -, *, /): ");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !char.TryParse(input, out operation))
            {
                Console.WriteLine("Error: Invalid operator input!");
                return;
            }

            // Get second number from user
            Console.Write("Enter second number: ");
            input = Console.ReadLine();
            if (!double.TryParse(input, out num2))
            {
                Console.WriteLine("Error: Invalid number input!");
                return;
            }

            Console.WriteLine();

            // Perform calculation based on operator using switch
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Error: Invalid operator! Please use +, -, *, or /");
                    break;
            }
            #endregion
        }
        #endregion
    }
}
