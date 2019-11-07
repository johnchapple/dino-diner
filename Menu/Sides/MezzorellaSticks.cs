using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
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
                switch (size)
                {
                    case Size.Small: { Price = .99; Calories = 540; } break;
                    case Size.Medium: { Price = 1.45; Calories = 610; } break;
                    case Size.Large: { Price = 1.95; Calories = 720; } break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> newIngredients = new List<string>();
                newIngredients.Add("Breading");
                newIngredients.Add("Cheese Product");
                newIngredients.Add("Vegetable Oil");
                return newIngredients;
            }
        }
        public MezzorellaSticks()
        {
            Price = .99;
            Calories = 540;
        }

        public override string ToString()
        {
            return $"{Size} Mezzorella Sticks";
        }

        public override string Description
        {
            get
            {
                return this.ToString();
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
