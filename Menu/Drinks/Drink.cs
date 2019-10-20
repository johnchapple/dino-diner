using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{

    public abstract class Drink : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
        
        /// <summary>
        /// Gets or sets whether there is ice or not
        /// </summary>
        public abstract bool Ice { get; set; }
        public virtual string Description
        {
            get { return this.ToString(); }
        }
        public abstract string[] Special { get; }

        public void HoldIce()
        {
            NotifyOfPropertyChanged("Special");
            Ice = false;
        }

        public override string ToString()
        {
            return "Drink";
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
