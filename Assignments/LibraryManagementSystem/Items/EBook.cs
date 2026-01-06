using System;

/// <summary>
/// Digital book with download behavior and zero late-fee logic.
/// </summary>
namespace LibraryManagementSystem.Items
{
    using LibraryManagementSystem;

    public class eBook : LibraryItem
    {
        #region Digital behavior
        public void Download()
        {
            Console.WriteLine("eBook downloaded successfully.");
        }
        #endregion

        #region Overrides
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: eBook");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Item ID: " + ItemID);
        }

        public override double CalculateLateFee(int days)
        {
            return 0;
        }
        #endregion
    }
}
