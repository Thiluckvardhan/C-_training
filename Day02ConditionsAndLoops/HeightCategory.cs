using System;

namespace Day2
{
    /// <summary>
    /// Categorizes height (in centimeters) into descriptive labels.
    /// </summary>
    class HeightCategory
{
    /// <summary>
    /// Reads a height value in centimeters and prints its category.
    /// </summary>
    /// <remarks>
    /// Categories: Dwarf (<150), Average (<165), Tall (<190), Abnormal (>=190).
    /// </remarks>
    public static void Height()
    {
        #region Variables
        // Read height input and hold computed category label
        Console.Write("Enter your Height: ");
        String? input = Console.ReadLine();
        double centi = 0.0;
        String result = string.Empty;
        #endregion

        #region Method Logic
        // Validate input; compute and display category or show error
        if (double.TryParse(input, out centi))
        {
            result = (centi < 150.0) ? "Dwarf" : (centi < 165) ? "Average" : (centi < 190) ? "Tall" : "Abnormal";
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please Enter the only Numbers");
        }
        #endregion
    }
}
}