namespace Day2
{
    class GradeDescription
{
    public static void Grader()
    {

        char grade; 

        if(!char.TryParse(Console.ReadLine(),out grade))
        {
            Console.WriteLine("Enter correct Input");
            return;
        }


        if (!char.IsLetter(grade))
        {
            Console.WriteLine("Enter only Letter As Input");
            return;
        }
        grade=char.ToLower(grade);
        switch (grade)
        {
            case 'e':
                Console.WriteLine("Excellent");
                break;
            case 'v':
                Console.WriteLine("Very Good");
                break;
            case 'g':
                Console.WriteLine("Good");
                break;
            case 'a':
                Console.WriteLine("Average");
                break;
            case 'f':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Enter proper Grade");
                break;
        }
    }
}
}