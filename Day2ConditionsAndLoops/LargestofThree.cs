using System;

namespace Day2
{
    /// <summary>
    /// Finds the largest of three numbers entered by the user.
    /// </summary>
    class LargestofThree
{
    /// <summary>
    /// Reads three numeric values and prints the largest among them.
    /// </summary>
    /// <remarks>
    /// Uses simple comparisons; treats invalid inputs as 0 due to TryParse fallback.
    /// </remarks>
    public static void Largest()
    {
        #region Variables
        // Store inputs and result
        double num1 = 0, num2 = 0, num3 = 0, largest = 0;
        String? input;
        #endregion

        #region Method Logic
        Console.WriteLine("Enter three Numbers : ");
        Console.Write("Num1: ");
        input = Console.ReadLine();
        double.TryParse(input, out num1);
        Console.Write("Num2: ");
        input = Console.ReadLine();
        double.TryParse(input, out num2);
        Console.Write("Num3: ");
        input = Console.ReadLine();
        double.TryParse(input, out num3);

        // Determine the largest value among inputs
        if (num1 <= num2 && num2 <= num3)
        {
            largest = num3;
        }
        else if (num1 >= num2 && num1 >= num3)
        {
            largest = num1;
        }
        else
        {
            largest = num2;
        }

        // Output the largest number
        Console.WriteLine(largest);
        #endregion
    }
}
}