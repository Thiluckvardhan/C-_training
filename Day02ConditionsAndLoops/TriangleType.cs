using System;

namespace Day2
{
    /// <summary>
    /// Classifies triangles based on side lengths.
    /// </summary>
    class TriangleType
{
    /// <summary>
    /// Reads three side lengths and determines the triangle type: Equilateral, Isosceles, or Scalene.
    /// </summary>
    /// <remarks>
    /// Validates that sides can form a valid triangle before classification.
    /// </remarks>
    public static void Check()
    {
        #region Variable Declaration
        double side1 = 0.0, side2 = 0.0, side3 = 0.0;
        #endregion

        #region Taking Input
        if (!double.TryParse(Console.ReadLine(), out side1))
        {
            Console.WriteLine("Enter a Number as input");
            return;
        }
        if (!double.TryParse(Console.ReadLine(), out side2))
        {
            Console.WriteLine("Enter a Number as input");
            return;
        }
        if (!double.TryParse(Console.ReadLine(), out side3))
        {
            Console.WriteLine("Enter a Number as input");
            return;
        }
        #endregion

        #region Triangle Check Logic
        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            Console.WriteLine("The Given sides does not form a triangle");
        }
        else if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Equilateral Triangle");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Isosceles Triangle");
        }
        else
        {
            Console.WriteLine("Scalene Triangle");
        }
        #endregion
        
    }
}
}