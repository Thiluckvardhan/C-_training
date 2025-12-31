using ExamSchedular.Model;
using ExamSchedular.Data;

/// <summary>
/// Main program to demonstrate static data storing and retrieval.
/// Fetches student and section data from static data sources and displays them.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point of the application.
    /// Retrieves and displays student and section information.
    /// </summary>
    public static void Main()
    {
        // Retrieve all students data from the static DataBank
        var localStudent = DataBank.GetStudentsData();
        
        // Display each student's ID and Name
        foreach (var student in localStudent)
        {
            System.Console.WriteLine($"{student.Id} {student.Name}");
        }

        // Retrieve all section details from the static DataSection
        var localSection = DataSection.GetSectionDetails();
        
        // Display each section's ID
        foreach (var section in localSection)
        {
            System.Console.WriteLine($"{section.Id}");
        }
    }
}