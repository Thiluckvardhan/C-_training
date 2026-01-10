namespace Libraryitem
{
    /// <summary>
    /// Base abstraction for any item available in the library.
    /// </summary>
    public abstract class LibraryItem
    {
        #region Properties
        // Title of the library item.
        public string? Title { get; set; }
        // Author/creator of the library item.
        public string? Auther { get; set; }
        #endregion

        #region Fields
        // Unique identifier assigned to the item.
        public int ItemId;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes shared item details.
        /// </summary>
        public LibraryItem(string title, string auther, int id)
        {
            this.Title = title;
            this.Auther = auther;
            this.ItemId = id;
        }
        #endregion

        #region Abstract Members
        /// <summary>
        /// Displays item information to the console.
        /// </summary>
        public abstract void DisplayItem();
        /// <summary>
        /// Calculates late fees based on the provided days.
        /// </summary>
        public abstract void CalcLateFee(int days);
        #endregion
    }

}