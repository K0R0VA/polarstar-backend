using System.Collections.Generic;

namespace Core.entities.order
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<CartLine> CartLines { get; set; }
    }
}