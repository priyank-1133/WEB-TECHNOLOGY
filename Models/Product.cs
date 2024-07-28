using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ShippingCost { get; set; }
    }
}
