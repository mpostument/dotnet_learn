namespace partials.UserManager;

public class EmailService : INotificationService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}