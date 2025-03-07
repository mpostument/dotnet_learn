namespace partials.Order;

public partial class Order
{
    public void ProcessOrder()
    {
        Console.WriteLine($"{OrderId} with date {OrderDate} processing...");
        OrderConfirmed();
    }

    private partial void OrderConfirmed()
    {
        Console.WriteLine("Order Confirmed");
    }
    
}