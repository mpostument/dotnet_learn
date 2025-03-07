namespace partials.OrderProcessing;

public class EmailNotification : INotificationServiceNew
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}