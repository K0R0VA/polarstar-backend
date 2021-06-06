using System;

namespace Core.entities.products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
        public uint Quantity { get; set; }
        public DateTime DatePrice { get; set; }
    }
}