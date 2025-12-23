/// <summary>
/// Admission Eligibility Checker
/// 
/// This program checks whether a student is eligible for admission based on their marks in three subjects:
/// Mathematics, Chemistry, and Physics.
/// 
/// Eligibility Criteria:
/// A student is considered eligible if:
/// 1. Total marks >= 180, OR
/// 2. Mathematics + Physics marks >= 140
/// 
/// The program takes input for marks in all three subjects and validates them before performing the eligibility check.
/// </summary>

namespace Day2
{
    class AdmissionEligibility
{
    public static void EligibilityCheck()
    {
        #region Variable Declaration
        double math_marks = 0.0, chem_marks = 0.0, phy_marks = 0.0, total_marks = 0.0;
        #endregion

        #region Taking Input
        Console.Write("Enter the Marks obtained in maths: ");
        if (!double.TryParse(Console.ReadLine(), out math_marks))
        {
            Console.WriteLine("Invalid marks");
            return;
        }
        Console.Write("Enter the Marks obtained in chemistry: ");
        if (!double.TryParse(Console.ReadLine(), out chem_marks))
        {
            Console.WriteLine("Invalid marks");
            return;
        }
        Console.Write("Enter the Marks obtained in physics: ");
        if (!double.TryParse(Console.ReadLine(), out chem_marks))
        {
            Console.WriteLine("Invalid marks");
            return;
        }
        #endregion

        #region Eligibility Check 
        total_marks = math_marks + chem_marks + phy_marks;
        if (total_marks >= 180 || math_marks + phy_marks >= 140)
        {
            Console.WriteLine("Student is Eligible");
        }
        else
        {
            Console.WriteLine("Student is not Eligible");
        }
        #endregion
    }
}
}