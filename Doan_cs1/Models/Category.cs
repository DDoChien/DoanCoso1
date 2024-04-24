namespace Doan_cs1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        
        public required List<Product> Products { get; set; }
    }
}
