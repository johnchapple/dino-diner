using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items;

        public double SubtotalCost
        {
            get
            {
                double cost = 0;
                foreach (IOrderItem i in Items)
                {
                    cost += i.Price;
                }
                if (cost < 0) { cost = 0; }
                return cost;
            }
            set
            {
                SubtotalCost = value;
            }
        }

        protected double SalesTaxRate
        {
            get
            {
                return SalesTaxRate;
            }
            set
            {
                SalesTaxRate = value;
            }
        }

        public double SalesTaxCost
        {
            get
            {
                return (SalesTaxRate * SubtotalCost);
            }
        }

        public double TotalCost
        {
            get
            {
                return (SubtotalCost + SalesTaxCost);
            }
        }
    }
}
