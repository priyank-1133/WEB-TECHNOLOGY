namespace Assignment3.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<CartProduct> Products { get; set; } = new List<CartProduct>();
    }

    public class CartProduct
    {
        public int CartId { get; set; } 
        public int ProductId { get; set; } 
        public int Quantity { get; set; }

        public Cart? Cart { get; set; } 
        public Product? Product { get; set; } 
    }
}
