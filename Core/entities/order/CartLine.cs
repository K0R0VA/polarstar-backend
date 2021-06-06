using Core.entities.products;

namespace Core.entities.order
{
    public class CartLine
    {
        public uint Id { get; set; }
        public Product Product { get; set; }
        public uint Quantity { get; set; }
        
        public int CartId { get; set; }
        public Cart Cart { get; set; }
    }
}