using Libraryitem;
using LibrarySystem.Items;
using Libraryanalytics;
/// <summary>
/// Simple runner to exercise the library management system.
/// </summary>
public class Program()
{
    #region Entry Point
    /// <summary>
    /// Bootstraps the demo by creating sample items and displaying analytics.
    /// </summary>
    public static void Main(string[] args)
    {
        Book book1=new Book("C# Fundamentals","John Doe",101);
        Magazine magazine1=new Magazine("Tech Today","Jane Doe",201);

        List<LibraryItem> libraryitems=new();

        libraryitems.Add(book1);
        libraryitems.Add(magazine1);
        foreach(var item in libraryitems)
        {
            item.DisplayItem();
        }
        Console.WriteLine();
        LibraryAnalytics.DisplayAnalytics();
        book1.Reserve();
        LibraryAnalytics.DisplayAnalytics();
    }
    #endregion
}
