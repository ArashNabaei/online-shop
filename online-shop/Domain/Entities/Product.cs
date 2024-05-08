using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public string Manufacturer { get; set; }
        public DateTime CreationDate { get; set; }
        public string ImageUrl { get; set; }

    }
}
