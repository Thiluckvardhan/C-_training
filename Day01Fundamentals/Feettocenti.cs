using System;
using System.Xml.Serialization;

namespace Day1
{
    /// <summary>
    /// Converts a measurement in feet to centimeters.
    /// </summary>
    class Feettocenti
{
    /// <summary>
    /// Reads a value in feet from the console and prints the value in centimeters.
    /// </summary>
    /// <remarks>
    /// Uses the conversion: 1 foot = 30.48 centimeters.
    /// </remarks>
    public static void feet()
    {
        #region Variables
        // Input string representing a length in feet
        String? input = Console.ReadLine();
        // Parsed numeric value (feet) reused to store computed centimeters
        double centi;
        #endregion

        #region Method Logic
        // Try to parse input; if valid, convert to centimeters
        if (double.TryParse(input, out centi))
        {
            centi = centi * (30.48);
        }
        // Print the resulting value (0 if parsing failed)
        Console.Write(centi);
        #endregion
    }
}
}