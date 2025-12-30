using System;
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
    /// <summary>
    /// Provides functionality to evaluate admission eligibility based on subject marks.
    /// </summary>
    class AdmissionEligibility
{
    /// <summary>
    /// Reads marks for Mathematics, Chemistry, and Physics, then prints whether the student is eligible.
    /// </summary>
    /// <remarks>
    /// This method does not accept parameters; it reads values from the console and performs validation.
    /// </remarks>
    public static void EligibilityCheck()
    {
        #region Variables
        // Holds marks for Mathematics, Chemistry, Physics and the computed total
        double math_marks = 0.0, chem_marks = 0.0, phy_marks = 0.0, total_marks = 0.0;
        #endregion

        #region Method Logic
        // Read and validate input for each subject
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
        
        // Compute total and check eligibility using given criteria
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