namespace Day1
{
    class Age
    {
        public static void age()
        {
        String? input=Console.ReadLine();
        if(int.TryParse(input,out int age))
        {
            if (age >= 18)
            {
                Console.Write("you are eligible to drink");
            }
            else
            {
                Console.Write("you are not eligible to drink");
            }
        }
        else
        {
            Console.Write("Invalid input");
        }
    }
}
}