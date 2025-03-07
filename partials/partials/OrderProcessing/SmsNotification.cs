namespace partials.OrderProcessing;

public class SmsNotification : INotificationServiceNew
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sms sent: {message}");
    }
}