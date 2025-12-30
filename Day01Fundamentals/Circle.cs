using System;

namespace Day1
{
    /// <summary>
    /// Provides circle-related calculations.
    /// </summary>
    class Circle
{
    /// <summary>
    /// Reads a radius from the console and prints the area of a circle.
    /// </summary>
    /// <remarks>
    /// Radius is expected as a numeric value. The area is computed using πr².
    /// </remarks>
    public static void PrintArea()
    {
        #region Variables
        // Read radius value from console input
        double r = Convert.ToDouble(Console.ReadLine());
        // Area of a circle (πr²)
        double area = Math.PI * r * r;
        #endregion

        #region Method Logic
        // Output the computed area to the console
        Console.WriteLine(area);
        #endregion
    }
}
}
