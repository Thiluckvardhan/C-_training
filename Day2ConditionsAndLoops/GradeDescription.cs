using System;

namespace Day2
{
    /// <summary>
    /// Maps letter grades to descriptive text.
    /// Accepts a single letter (E, V, G, A, F) and prints the corresponding description.
    /// </summary>
    class GradeDescription
{
    /// <summary>
    /// Reads a grade character from the console and prints its description.
    /// </summary>
    /// <remarks>
    /// Validates input to ensure a single letter; supports both uppercase and lowercase.
    /// </remarks>
    public static void Grader()
    {
        #region Variables
        // Stores the input grade character
        char grade; 
        #endregion

        #region Method Logic
        // Read and validate input: ensure it's a single character
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
        #endregion
    }
}
}