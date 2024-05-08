using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
