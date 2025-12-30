using System;

namespace Day1
{
    /// <summary>
    /// Simple utility for greeting a user by name.
    /// </summary>
    class PrintingName
{
    /// <summary>
    /// Reads a name from the console and prints a greeting.
    /// </summary>
    public static void name()
    {
        #region Variables
        // Prompt user and store the entered name
        Console.WriteLine("Enter your name: ");
        string? name = Console.ReadLine();
        #endregion

        #region Method Logic
        // Display a friendly greeting
        Console.WriteLine("Hello, " + name + "!");
        #endregion
    }
}
}
