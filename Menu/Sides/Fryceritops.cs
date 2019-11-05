using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side
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
                size = value;
                switch(size)
                {
                    case Size.Small: { Price = .99; Calories = 222; } break;
                    case Size.Medium: { Price = 1.45; Calories = 365; } break;
                    case Size.Large: { Price = 1.95; Calories = 480; } break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> newIngredients = new List<string>();
                newIngredients.Add("Potato");
                newIngredients.Add("Salt");
                newIngredients.Add("Vegetable Oil");
                return newIngredients;
            }
        }
        public Fryceritops()
        {
            Price = .99;
            Calories = 222;
        }

        public override string ToString()
        {
            return "Fryceritops";
        }

        public override string Description
        {
            get
            {
                return $"{Size} Fryceritops";
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
