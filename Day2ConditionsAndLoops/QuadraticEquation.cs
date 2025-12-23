namespace Day2
{
    class QuadraticEquation
{
    public static void Equate()
    {

        #region Variable Declaration
        double[] coeff = new double[3];
        double a = 0.0, b = 0.0, c = 0.0;
        String[] names = { "a", "b", "c" };
        double discriminant = 0.0;
        double root1 = 0.0, root2 = 0.0;
        #endregion

        #region Taking Input
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter {names[i]}: ");
            while (!double.TryParse(Console.ReadLine(), out coeff[i]))
            {
                Console.Write("Enter correct input");
            }
        }
        a = coeff[0];
        b = coeff[1];
        c = coeff[2];
        #endregion

        #region Finding Roots
        discriminant = b * b - 4 * a * c;
        if (discriminant > 0)
        {
            Console.WriteLine("Roots are Real and Distinct");
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Root1 is : " + root1);
            Console.WriteLine("Root2 is : " + root2);
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("Roots are Real and Equal");
            root1 = -b / (2 * a);
            Console.WriteLine("Both Roots are " + root1);
        }
        else
        {
            Console.WriteLine("No Real Roots Exists");
        }
        #endregion


    }
}
}