namespace Understanding_Delegates.Classes
{
    public class NotificationService
    {
        // Delegate handling notification
        public delegate void NotificationHandler(string message);

        // "messenger" to notify
        public NotificationHandler Notify;

        // send notification 
        public void SendNotification(string message)
        {
            if(Notify != null)
            {
                Notify(message);
            }
        }
    }

    // Class portraying subscriber.
    public class Subscriber
    {
        public string Username { get; set; }

        // Imagine this as a smartphone, showing user notification.
        public void ReceiveNotification(string message)
        {
            Console.WriteLine($"New notification for you {Username}: {message}");
        }
        
        // multicast delegate example.
        public void ReceiveAnotherNotification(string message)
        {
            Console.WriteLine($"New notification for you from other service {Username}: {message}");
        }
    }
}
