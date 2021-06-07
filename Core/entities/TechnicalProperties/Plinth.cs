using System.Collections.Generic;
using Core.entities.products;

namespace Core.entities.TechnicalProperties
{
    public class Plinth
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Spotlight> Spotlights { get; set; }
    }
}