namespace partials.UserManager;

public class UserManagerBad
{
    public void AddUser(string username, string email)
    {
        Console.WriteLine($"User {username} added to the system.");
        SendMessage(email, "Welcome!");
    }

    public void SendMessage(string receiver, string message)
    {
        Console.WriteLine($"{message}");
    }
}