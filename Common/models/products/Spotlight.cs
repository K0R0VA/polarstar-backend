using System.ComponentModel.DataAnnotations.Schema;
using Common.models.TechnicalProperties;

namespace Common.models.products
{
    [Table("Spotlights")]
    public class Spotlight: Lamp
    {
        public int LightFlow { get; set; }
        public Plinth? Plinth { get; set; }
    }
}