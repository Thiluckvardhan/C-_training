using System;

namespace Day2
{
    /// <summary>
    /// Determines if a given year is a leap year.
    /// </summary>
    class LeapYearCheck
{
    /// <summary>
    /// To Check Leap year or not
    /// </summary>
    public static void Leap()
    {
        #region variable Declaration
        String? input = String.Empty;
        int year = 0;
        bool leapyear = false;
        String result = String.Empty;
        #endregion

        #region Leap Year Check
        try
        {

            Console.WriteLine("Welcome to Leap Year Checker");
            Console.Write("Enter the year: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out year))
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0 && year % 400 == 0)
                    {
                        leapyear = true;
                    }
                    else if (year % 100 != 0)
                    {
                        leapyear = true;
                    }
                }
                result = leapyear ? "Leap Year" : "Not a Leap Year";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Enter Integer Input only");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An Unexpected error occured " + ex.Message);
        }
        #endregion
    }
}
}