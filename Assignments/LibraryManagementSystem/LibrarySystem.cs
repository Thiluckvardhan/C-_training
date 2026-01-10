using Libraryitem;
using Interfaces;
using Libraryanalytics;
namespace LibrarySystem
{
    namespace Items
    {
        /// <summary>
        /// Represents a book that can be reserved and notifies the member when ready.
        /// </summary>
        public class Book : LibraryItem, IReservable, INotifiable
        {
            #region Fields
            // Tracks whether the book is currently reserved.
            bool ReserveStatus = false;
            #endregion

            #region Constructors
            /// <summary>
            /// Builds a book instance with identifying details.
            /// </summary>
            public Book(string title, string auther, int id) : base(title, auther, id)
            {

            }
            #endregion

            #region Overrides
            /// <summary>
            /// Displays the book's details.
            /// </summary>
            public override void DisplayItem()
            {
                Console.WriteLine("Item Type :" + this.GetType());
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Auther: {Auther}");
                Console.WriteLine($"Item Id: {ItemId}");
            }

            /// <summary>
            /// Calculates the late fee for the book.
            /// </summary>
            public override void CalcLateFee(int days = 3)
            {
                Console.WriteLine($"Late Fee for 3 days : {days * 1.0}");
            }
            #endregion

            #region IReservable Implementation
            /// <summary>
            /// Reserves the book if available.
            /// </summary>
            public void Reserve()
            {
                if (!ReserveStatus)
                {
                    ReserveStatus = true;
                    LibraryAnalytics.borrowedcount++;
                    Console.WriteLine("Book Reserved");
                }
                else
                {
                    Console.WriteLine("Book Already Reserved");
                }
            }
            #endregion

            #region INotifiable Implementation
            /// <summary>
            /// Sends a notification for the reserved book.
            /// </summary>
            public void Notify()
            {
                Console.WriteLine("Notification sent: Your reserved book is ready for pickup");
            }
            #endregion
        }

        /// <summary>
        /// Represents a magazine that can be reserved and will notify the member when ready.
        /// </summary>
        public class Magazine : LibraryItem, IReservable, INotifiable
        {
            #region Fields
            // Tracks whether the magazine is currently reserved.
            bool ReserveStatus = false;
            #endregion

            #region Constructors
            /// <summary>
            /// Builds a magazine instance with identifying details.
            /// </summary>
            public Magazine(string title, string auther, int id) : base(title, auther, id)
            {

            }
            #endregion

            #region Overrides
            /// <summary>
            /// Displays the magazine's details.
            /// </summary>
            public override void DisplayItem()
            {
                Console.WriteLine("Item Type :" + this.GetType());
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Auther: {Auther}");
                Console.WriteLine($"Item Id: {ItemId}");
            }

            /// <summary>
            /// Calculates the late fee for the magazine.
            /// </summary>
            public override void CalcLateFee(int days = 3)
            {
                Console.WriteLine($"Late Fee for 3 days : {days * 0.5}");
            }
            #endregion

            #region IReservable Implementation
            /// <summary>
            /// Reserves the magazine if available.
            /// </summary>
            public void Reserve()
            {
                if (!ReserveStatus)
                {
                    ReserveStatus = true;
                    LibraryAnalytics.borrowedcount++;
                    Console.WriteLine("Book Reserved");
                    this.Notify();
                }
                else
                {
                    Console.WriteLine("Book Already Reserved");
                }
            }
            #endregion

            #region INotifiable Implementation
            /// <summary>
            /// Sends a notification for the reserved magazine.
            /// </summary>
            public void Notify()
            {
                Console.WriteLine("Notification sent: Your reserved Magazine is ready for pickup");
            }
            #endregion
        }
    }


    namespace Users
    {
        /// <summary>
        /// Placeholder for member-specific behavior and data.
        /// </summary>
        public class Member
        {

        }
    }
}