namespace partials.UserManager;

public class UserManager
{
    private INotificationService _notificationService;

    public UserManager(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    
    
    public void AddUser(string username, string email)
    {
        Console.WriteLine($"User {username} added to the system.");
        _notificationService.SendMessage("Welcome To Site!");
    }
}