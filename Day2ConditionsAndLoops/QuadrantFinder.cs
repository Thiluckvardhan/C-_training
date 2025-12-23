namespace Day2
{
    class QuadrantFinder
{
    public static void Finder()
    {
        #region Varaible Declaration
        double x_coordi = 0.0, y_coordi = 0.0;
        #endregion

        #region Taking Input
        Console.WriteLine("Enter X coordinate Value: ");
        if (!double.TryParse(Console.ReadLine(), out x_coordi))
        {
            Console.WriteLine("Enter only Numerical Input");
        }
        Console.WriteLine("Enter Y coordinate Value: ");
        if (!double.TryParse(Console.ReadLine(), out y_coordi))
        {
            Console.WriteLine("Enter only Numerical Input");
        }
        #endregion

        #region Quadrant Checking Logic
        if (x_coordi == 0 || y_coordi == 0)
        {
            Console.WriteLine("The Coordinates lie at origin or on axis");
        }
        else if (x_coordi > 0 && y_coordi > 0)
        {
            Console.WriteLine("The coordinate Lie in 1st Quadrant");
        }
        else if (x_coordi > 0 && y_coordi < 0)
        {
            Console.WriteLine("The coordinate Lie in 2nd Quadrant");
        }
        else if (x_coordi < 0 && y_coordi < 0)
        {
            Console.WriteLine("The coordinate Lie in 3rd Quadrant");
        }
        else
        {
            Console.WriteLine("The Coordinate Lie in 4th Quadrant");
        }
        #endregion

    }
}
}