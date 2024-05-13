using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public enum OrderStatus
        {
            Pending,
            Shipped,
            Delivered,
            Cancelled
        }
        public OrderStatus Status { get; set; }
        public double TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public Cart Cart { get; set; }
        public User User { get; set; }
    }
}