using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class CartItem
    {
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Cart")]
        public Guid CartId { get; set; }
        public Cart Cart { get; set; }
    }
}
