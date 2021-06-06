using Core.entities.TechnicalProperties;

namespace Core.entities.products
{
    public class Lamp: Product
    {
        public float Mass { get; set; }
        public int LowVoltage { get; set; }
        public int HighVoltage { get; set; }
        public int Power { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int LowTemperature { get; set; }
        public int HighTemperature { get; set; }
        
        public int ProtectionId { get; set; }
        public Protection Protection { get; set; }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}