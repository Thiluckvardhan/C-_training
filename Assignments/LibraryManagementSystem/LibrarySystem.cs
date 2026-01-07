using Libraryitem;
using Interfaces;
using Libraryanalytics;
namespace LibrarySystem
{
    namespace Items
    {
        public class Book : LibraryItem, IReservable, INotifiable
        {
            bool ReserveStatus = false;
            public Book(string title, string auther, int id) : base(title, auther, id)
            {

            }
            public override void DisplayItem()
            {
                Console.WriteLine("Item Type :" + this.GetType());
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Auther: {Auther}");
                Console.WriteLine($"Item Id: {ItemId}");
            }

            public override void CalcLateFee(int days = 3)
            {
                Console.WriteLine($"Late Fee for 3 days : {days * 1.0}");
            }

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

            public void Notify()
            {
                Console.WriteLine("Notification sent: Your reserved book is ready for pickup");
            }
        }

        public class Magazine : LibraryItem, IReservable, INotifiable
        {
            bool ReserveStatus = false;
            public Magazine(string title, string auther, int id) : base(title, auther, id)
            {

            }
            public override void DisplayItem()
            {
                Console.WriteLine("Item Type :" + this.GetType());
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Auther: {Auther}");
                Console.WriteLine($"Item Id: {ItemId}");
            }

            public override void CalcLateFee(int days = 3)
            {
                Console.WriteLine($"Late Fee for 3 days : {days * 0.5}");
            }

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

            public void Notify()
            {
                Console.WriteLine("Notification sent: Your reserved Magazine is ready for pickup");
            }
        }
    }


    namespace Users
    {
        public class Member
        {

        }
    }
}