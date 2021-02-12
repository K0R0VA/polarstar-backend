using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace Common.models.filters
{
    public static class FilterExtension
    {
        public static IQueryable<T> Filter<T>(this IQueryable<T> values, IFilterable<T> filter)
        {
            return values.Where(value => filter.Filter(value));
        }
    }
}