using System;

/// <summary>
///  Partial analytics class exposing display helpers.
/// </summary>
namespace LibraryManagementSystem
{
    public partial class LibraryAnalytics
    {
        #region Display
        public static void DisplayAnalytics()
        {
            Console.WriteLine("Total Items Borrowed: " + TotalBorrowedItems);
        }
        #endregion
    }
}
