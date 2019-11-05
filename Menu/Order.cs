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
        public List<IOrderItem> items = new List<IOrderItem>();

        public Order()
        {
        }
        
        public IOrderItem[] Items {  get { return items.ToArray(); } }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                item.PropertyChanged -= OnPropertyChanged;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
            return removed;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

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
