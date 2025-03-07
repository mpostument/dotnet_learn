namespace partials.Order;

public partial class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    
    private partial void OrderConfirmed();
}