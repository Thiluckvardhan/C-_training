using System;
using System.Collections.Generic;
using ItemsAlias = LibraryManagementSystem.Items;
/// <summary>
/// Demonstrates abstract base usage, late-fee overrides, explicit interface calls,
/// runtime polymorphism, static analytics, enum-driven messaging, and bonus eBook behavior.
/// </summary>

namespace LibraryManagementSystem
{
    using Items;
    using Users;

    internal class Program
    {
        private static void Main()
        {
            #region Item setup
            ItemsAlias.Book book = new ItemsAlias.Book
            {
                Title = "C# Fundamentals",
                Author = "Thiluck",
                ItemID = 101
            };

            ItemsAlias.Magazine magazine = new ItemsAlias.Magazine
            {
                Title = "C++",
                Author = "xyz",
                ItemID = 201
            };
            #endregion

            #region Abstract/late fee demo
            book.DisplayItemDetails();
            Console.WriteLine("Late Fee for 3 days: " + book.CalculateLateFee(3));
            Console.WriteLine();

            magazine.DisplayItemDetails();
            Console.WriteLine("Late Fee for 3 days: " + magazine.CalculateLateFee(3));
            Console.WriteLine();
            #endregion

            #region Interfaces (explicit impl access)
            IReservable reservable = book;
            INotifiable notifiable = book;

            // Interface calls must go through the interface references (explicit implementation).

            reservable.Reserve();
            notifiable.Notify("Please return the book on time.");
            Console.WriteLine();
            #endregion

            #region Polymorphism loop
            List<LibraryItem> items = new List<LibraryItem> { book, magazine };

            foreach (var item in items)
            {
                // Dynamic dispatch hits the derived implementation at runtime.
                item.DisplayItemDetails();
                Console.WriteLine();
            }
            #endregion

            #region Analytics (static)
            LibraryAnalytics.TotalBorrowedItems += 5;
            // Static method reads shared analytics state.
            LibraryAnalytics.DisplayAnalytics();
            Console.WriteLine();
            #endregion

            #region Enums and notifications
            Member member = new Member
            {
                Name = "Alex",
                Role = UserRole.Member
            };

            ItemStatus status = ItemStatus.Borrowed;

            Console.WriteLine("User Role: " + member.Role);
            Console.WriteLine("Item Status: " + status);
            Console.WriteLine();

            if (member.Role == UserRole.Admin)
            {
                Console.WriteLine("Admin Alert: System maintenance scheduled.");
            }
            else
            {
                Console.WriteLine("Member Notification: Your borrowed item is due tomorrow.");
            }
            #endregion

            #region Bonus eBook behavior
            ItemsAlias.eBook ebook = new ItemsAlias.eBook
            {
                Title = "C Fundamentals",
                Author = "EAuthor",
                ItemID = 301
            };

            ebook.DisplayItemDetails();
            ebook.Download();
            #endregion
        }
    }
}
