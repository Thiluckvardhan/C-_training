using System;

namespace Day9Indexer
{
    public interface INotification
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

    public class SMS : INotification
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

    public class NotificationService
    {
        private readonly INotification _notification;

        public NotificationService(INotification notification)
        {
            _notification = notification;
        }

        public void Notify(string message)
        {
            _notification.SendNotification(message);
        }
    }
}
