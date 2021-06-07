using System;
using System.Collections.Generic;
using Core.entities.order;

namespace Core.entities.products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DatePrice { get; set; }
        
        public ICollection<CartLine> CartLines { get; set; }
    }
}