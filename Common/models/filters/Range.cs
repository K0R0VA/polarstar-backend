using System;
using System.Collections.Generic;
using Utils;

namespace Common.models.filters
{
    public readonly struct Range<T>: IFilterable<T> where T: IComparable<T>
    {
        public Range(T lowValue, T highValue)
        {
            LowValue = lowValue;
            HighValue = highValue;
        }
        private T LowValue { get;  }
        private T HighValue { get; }


        public bool Filter(T value)
        {
            return LowValue.CompareTo(value) < 0 && value.CompareTo(HighValue) < 0;
        }
    }
}