namespace Day2
{
    class HeightCategory
{
    /// <summary>
    /// 
    /// </summary>
    public static void Height()
    {
        
        Console.Write("Enter your Height: ");
        String? input = Console.ReadLine();
        double centi = 0.0;
        String result = string.Empty;
        if (double.TryParse(input, out centi))
        {
            result = (centi < 150.0) ? "Dwarf" : (centi < 165) ? "Average" : (centi < 190) ? "Tall" : "Abnormal";
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please Enter the only Numbers");
        }
    }
}
}