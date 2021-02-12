using System;
using System.Collections.Generic;
using Common.models.filters;
using Common.models.products;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void InRange()
        {
            var range = new Range<int>(Int32.MinValue, Int32.MaxValue);
            var item = 123;
            Assert.True(range.Filter(item));
        }
        [Fact]
        public void OutOfRange()
        {
            var range = new Range<int>(124, Int32.MaxValue);
            var item = 123;
            Assert.False(range.Filter(item));
        }
    }
}