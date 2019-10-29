using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.Collections.ObjectModel;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldCalculatePrice()
        {
            Order o = new Order();
            o.Add(new JurrasicJava());
            o.Add(new Brontowurst());
            o.Add(new Triceritots());
            Assert.Equal<double>(6.94, o.SubtotalCost);
        }
    }
}
