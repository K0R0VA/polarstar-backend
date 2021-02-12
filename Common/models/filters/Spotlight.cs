using System.Collections.Generic;
using System.Linq;
using Common.models.products;

namespace Common.models.filters
{
    public record SpotlightFilter: LampFilter, IFilterable<Spotlight> 
    {
        
        private Range<int> RangeLightFlow { get; set; }
        private IEnumerable<string> Plinths { get; set; }
        public bool Filter(Spotlight spotlight)
        {
            throw new System.NotImplementedException();
        }

        private bool FilterByLampProperties(Lamp lamp) => base.Filter(lamp);

        private bool FilterBySpotlightProperties(Spotlight spotlight)
        {
            return IsPlinthInList(spotlight.Plinth?.Name) && IsLightFlowInRange(spotlight.LightFlow);
        }

        private bool IsLightFlowInRange(int lightFlow) => RangeLightFlow.Filter(lightFlow);
        private bool IsPlinthInList(string? name) => Plinths.Any(p => p == name);
    }
}