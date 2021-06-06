using Core.entities.TechnicalProperties;

namespace Core.entities.products
{
    public class Spotlight: Lamp
    {
        public int LightFlow { get; set; }
        
        public int PlinthId { get; set; }
        public Plinth Plinth { get; set; }
    }
}