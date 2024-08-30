public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }

    public User User { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
