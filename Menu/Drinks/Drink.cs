using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{

    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public abstract class Drink
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

        public void HoldIce()
        {
            Ice = false;
        }

        public override string ToString()
        {
            return "Drink";
        }

    }
}
