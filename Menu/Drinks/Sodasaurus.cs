using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {
        private Size size;

        public override Size Size
        {
            get
            {
                return size;
            }

            set
            {
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                size = value;
                switch (size)
                {
                    case Size.Small: { Price = 1.50; Calories = 112; } break;
                    case Size.Medium: { Price = 2.00; Calories = 156; } break;
                    case Size.Large: { Price = 2.50; Calories = 208; } break;
                }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> newIngredients = new List<string>();
                newIngredients.Add("Water");
                newIngredients.Add("Natural Flavors");
                newIngredients.Add("Cane Sugar");
                return newIngredients;
            }
        }
        public Sodasaurus()
        {
            Ice = true;
            Price = 1.50;
            Calories = 112;
        }

        public override string ToString()
        {
            return "Sodasaurus";
        }

        public override bool Ice { get; set; }

        public SodasaurusFlavor Flavor;

        public override string Description
        {
            get
            {
                return "Sodasaurus";
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) { special.Add("Hold Ice"); }
                return special.ToArray();
            }
        }
    }
}
