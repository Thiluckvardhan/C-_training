using System;

/// <summary>
/// Abstract base for all library items defining shared data and behaviors.
/// </summary>
namespace LibraryManagementSystem.Items
{
    using LibraryManagementSystem;

    public abstract class LibraryItem
    {
        #region Properties
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int ItemID { get; set; }
        #endregion

        #region Abstract members
        public abstract void DisplayItemDetails();
        public abstract double CalculateLateFee(int days);
        #endregion
    }
}
