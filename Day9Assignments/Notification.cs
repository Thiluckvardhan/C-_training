using System;
using System.Collections.Generic;
using System.Text;

namespace Day9Indexer
{
    interface INotification
    {
        void SendNotification(string message);
    }

    public class Email : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Email Notification: " + message);
        }
    }
    
    public class SMS:INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }
    }

    public class WhatsApp : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("WhatsApp Notification: " + message);
        }
    }
}
