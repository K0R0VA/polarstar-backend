using Common.models.products;

namespace Common.models.filters
{
    public record ProductFilter : IFilterable<Product> {
        private string Name { get; set; }
        private Range<double> PriceRange { get; set; }
        private uint MinQuantity { get; set; }

        public bool Filter(Product value)
        {
            return IsNameEqual(value.Name) && IsPriceInRange(value.Price) &&
                   IsBiggerThanMinQuantity(value.Quantity);
        }
        private bool IsNameEqual(string name) => name.Contains(Name) || Name.Contains(name);
        private bool IsPriceInRange(double price) => PriceRange.Filter(price);
        private bool IsBiggerThanMinQuantity(uint quantity) => quantity >= MinQuantity;
    }
}