using System;

/// <summary>
/// Concrete magazine item with type-specific display and late fee logic.
/// </summary>
namespace LibraryManagementSystem.Items
{
    using LibraryManagementSystem;

    public class Magazine : LibraryItem
    {
        #region Overrides
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: Magazine");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Item ID: " + ItemID);
        }

        public override double CalculateLateFee(int days)
        {
            return days * 0.5;
        }
        #endregion
    }
}
