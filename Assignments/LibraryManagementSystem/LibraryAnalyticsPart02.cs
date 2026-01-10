namespace Libraryanalytics
{
    /// <summary>
    /// Provides analytics display helpers.
    /// </summary>
    public partial class LibraryAnalytics
    {
        #region Display Methods
        /// <summary>
        /// Shows current analytics related to borrowing counts.
        /// </summary>
        public static void DisplayAnalytics()
        {
            Console.WriteLine($"Total Items Borrowed : {borrowedcount}");
        }
        #endregion
    }
}
