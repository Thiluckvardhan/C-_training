namespace Day2
{
    class LargestofThree
{
    public static void Largest()
    {
        double num1 = 0, num2 = 0, num3 = 0, largest = 0;
        Console.WriteLine("Enter three Numbers : ");
        Console.Write("Num1: ");
        String? input = Console.ReadLine();
        double.TryParse(input, out num1);
        Console.Write("Num2: ");
        input = Console.ReadLine();
        double.TryParse(input, out num2);
        Console.Write("Num3: ");
        input = Console.ReadLine();
        double.TryParse(input, out num3);

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

        Console.WriteLine(largest);
    }
}
}