using Common.models.products;
using Utils;

namespace Common.models.filters
{
    public record SearchlightFilter: LampFilter, IFilterable<Searchlight>
    {
        private Range<int> RangeLightingRange { get; set; }
        private Range<int> RangeDiameter { get; set; }
        
        public bool Filter(Searchlight searchlight) => 
            FilterByLampProperties(searchlight) && FilterBySearchlightProperties(searchlight);
        private bool FilterByLampProperties(Lamp lamp) => base.Filter(lamp);
        private bool FilterBySearchlightProperties(Searchlight searchlight) => 
            IsDiameterInRange(searchlight.Diameter) && IsLightRangeInRange(searchlight.LightingRange);

        private bool IsLightRangeInRange(int lightingRange) => RangeLightingRange.Filter(lightingRange);
        private bool IsDiameterInRange(int diameter) => RangeDiameter.Filter(diameter);
    }
}