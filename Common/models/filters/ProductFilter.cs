using System;
using System.Diagnostics;
using Common.models.products;
using Utils;

namespace Common.models.filters
{
    public record ProductFilter : IFilterable<Product> {
        private string Name { get; set; }
        private double LowPrice { get; set; } 
        private double HighPrice { get; set; }
        private uint MinQuantity { get; set; }
        private DateTime DatePrice { get; set; }
        
        public bool Filter(Product product)
        {
            return IsNameEqual(product.Name) && IsPriceInRange(product.Price) && IsBiggerThanMinQuantity(product.Quantity)
        }
        private bool IsNameEqual(string name) => name.Contains(Name) || Name.Contains(name);
        private bool IsPriceInRange(double price) => LowPrice < price && price < HighPrice;
        private bool IsBiggerThanMinQuantity(uint quantity) => quantity > MinQuantity;
    }
}