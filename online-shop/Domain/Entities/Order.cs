namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public enum OredrStatus
        {
            Pending,
            Shipped,
            Delivered,
            Cancelled
        }
        public OrderStatus Status { get; set; }
        public double TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
    }
}