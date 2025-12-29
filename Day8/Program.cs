using ExamSchedular.Model;
using ExamSchedular.Data;

public class Program
{
    public static void Main()
    {
        var localStudent = DataBank.GetStudentsData();
        foreach (var student in localStudent)
        {
            System.Console.WriteLine($"{student.Id} {student.Name}");
        }

        var localSection = DataSection.GetSectionDetails();
        foreach (var section in localSection)
        {
            System.Console.WriteLine($"{section.Id}");
        }
    }
}