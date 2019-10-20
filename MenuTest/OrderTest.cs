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
            ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
            items.Add(new JurrasicJava());
            items.Add(new Brontowurst());
            items.Add(new Triceritots());
            o.Items = items;
            Assert.Equal<double>(6.94, o.SubtotalCost);
        }
    }
}
