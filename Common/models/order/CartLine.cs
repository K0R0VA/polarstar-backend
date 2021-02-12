using System.Text.Json.Serialization;
using Common.models.products;

namespace Common.models.order
{
    public class CartLine
    {
        public uint Id { get; set; }
        public Product Product { get; set; }
        public uint Quantity { get; set; }
        [JsonIgnore]
        public Cart Cart { get; set; }
    }
}