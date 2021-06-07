using System.Collections.Generic;
using Core.entities.products;

namespace Core.entities.TechnicalProperties
{
    public class Protection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Lamp> Lamps { get; set; }
    }
}