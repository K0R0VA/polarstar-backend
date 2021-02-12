using System;
using System.Collections.Generic;
using Common.models.products;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Product lamp = new Searchlight();
            switch (lamp.GetType().Name)
            {
                case "Lamp": Assert.False(true);
                    break;
                case "Product": Assert.False(true);
                    break;
                case "Searchlight": Assert.True(true);
                    break;
            }
        }
    }
}