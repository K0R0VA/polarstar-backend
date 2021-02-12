using System.Collections.Generic;
using System.Linq;
using Common.models.products;
using Common.models.TechnicalProperties;
using Utils;

namespace Common.models.filters
{
    public record LampFilter: ProductFilter, IFilterable<Lamp>
    {
        private Range<float> RangeMass { get; set; }
        private Range<int> RangeLowVoltage { get; set; }
        private Range<int> RangeHighVoltage { get; set; }
        private Range<int> RangePower { get; set; }
        private Range<int> RangeLength { get; set; }
        private Range<int> RangeWidth { get; set; }
        private IEnumerable<string> Protections { get; set; }
        private Range<int> RangeLowTemperature { get; set; }
        private Range<int> RangeHighTemperature { get; set; }
        
        public bool Filter(Lamp lamp)
        {
            return FilterByProductProperties(lamp) && FilterByLampProperties(lamp);
        }

        private bool FilterByProductProperties(Product product) => base.Filter(product);
        private bool FilterByLampProperties(Lamp lamp) =>
            IsLengthInRange(lamp.Length) && IsMassInRange(lamp.Mass) && IsPowerInRange(lamp.Power) &&
            IsLowTemperatureInRange(lamp.LowTemperature)
            && IsHighTemperatureInRange(lamp.HighTemperature) && IsLowVoltageInRange(lamp.LowVoltage) &&
            IsHighVoltageInRange(lamp.HighVoltage)
            && IsWidthInRange(lamp.Width) && IsProtectionInListOfProtection(lamp.Protection?.Name);

        private bool IsMassInRange(float mass) => RangeMass.Filter(mass);
        private bool IsLowVoltageInRange(int lowVoltage) => RangeLowVoltage.Filter(lowVoltage);
        private bool IsHighVoltageInRange(int highVoltage) => RangeHighVoltage.Filter(highVoltage);
        private bool IsPowerInRange(int power) => RangePower.Filter(power);
        private bool IsWidthInRange(int width) => RangeWidth.Filter(width);
        private bool IsLengthInRange(int length) => RangeLength.Filter(length);
        private bool IsProtectionInListOfProtection(string? protectionName) => Protections.Any(protection => protection == protectionName);
        private bool IsLowTemperatureInRange(int temperature) => RangeLowTemperature.Filter(temperature);
        private bool IsHighTemperatureInRange(int temperature) => RangeHighTemperature.Filter(temperature);
    }
}