namespace delegates;

public delegate void NotificationHandler(string message);

public class NotificationService
{
    public NotificationHandler Handler = null;

    public NotificationService(NotificationHandler handler)
    {
        Handler = handler;
    }
    
    public NotificationService(List<NotificationHandler> handlers)
    {
        foreach (var action in handlers)
        {
            Handler += action;
        }
    }
    
    public NotificationService() {}
    
    public void Send(string message)
    {
        
        Handler?.Invoke(message);
    }
}