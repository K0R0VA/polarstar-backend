using System;
using Common.models.filters;
using Utils;

namespace Common.models.products
{
    public class Product
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public uint Quantity { get; set; }
        public DateTime DatePrice { get; set; }
    }
}