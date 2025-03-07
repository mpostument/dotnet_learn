namespace partials.OrderProcessing;

public class OrderProcessor
{
    private INotificationServiceNew _notificationService;

    public OrderProcessor(INotificationServiceNew notificationService)
    {
        _notificationService = notificationService;
    }

    public void ProcessOrder(string orderId)
    {
        _notificationService.SendNotification($"Order {orderId} confirmed!");
    }
}