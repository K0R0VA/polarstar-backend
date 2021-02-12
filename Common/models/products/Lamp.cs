using System.ComponentModel.DataAnnotations.Schema;
using Common.models.TechnicalProperties;

namespace Common.models.products
{
    [Table("Lamps")]
    public class Lamp: Product
    {
        public float Mass { get; set; }
        public int LowVoltage { get; set; }
        public int HighVoltage { get; set; }
        public int Power { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public Protection? Protection { get; set; }
        public int? LowTemperature { get; set; }
        public int? HighTemperature { get; set; }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}