using System.ComponentModel.DataAnnotations.Schema;

namespace Common.models.products
{
    [Table("Searchlights")]
    public class Searchlight: Lamp
    {
        public int LightingRange { get; set; }
        public int Diameter { get; set; }
    }
}