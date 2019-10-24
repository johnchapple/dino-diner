using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        public ObservableCollection<IOrderItem> Items;

        public Order()
        {
            this.Items = new ObservableCollection<IOrderItem>();
            this.Items.CollectionChanged += this.OnCollectionChanged;

        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            NotifyOfPropertyChanged("SubtotalCost");
        }
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
