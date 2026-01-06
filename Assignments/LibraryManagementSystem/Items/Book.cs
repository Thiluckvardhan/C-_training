using System;

/// <summary>
/// Concrete book item with explicit reservation and notification implementations.
/// </summary>
namespace LibraryManagementSystem.Items
{
    using LibraryManagementSystem;

    public class Book : LibraryItem, IReservable, INotifiable
    {
        #region Interface implementations
        void IReservable.Reserve()
        {
            Console.WriteLine("Book reserved successfully.");
        }

        void INotifiable.Notify(string message)
        {
            Console.WriteLine("Notification: " + message);
        }
        #endregion

        #region Overrides
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: Book");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Item ID: " + ItemID);
        }

        public override double CalculateLateFee(int days)
        {
            return days * 1.0;
        }
        #endregion
    }
}
