using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
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
                    case Size.Small: { Price = 0.1; Calories = 0; } break;
                    case Size.Medium: { Price = 0.1; Calories = 0; } break;
                    case Size.Large: { Price = 0.1; Calories = 0; } break;
                }
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> newIngredients = new List<string>();
                newIngredients.Add("Water");
                if (Lemon) { newIngredients.Add("Lemon"); }
                return newIngredients;
            }
        }
        public Water()
        {
            Price = 0.1;
            Calories = 0;
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public override string ToString()
        {
            return $"{Size} Water";
        }

        private bool _ice = true;
        public override bool Ice
        {
            get
            {
                return _ice;
            }
            set
            {
                _ice = value;
                NotifyOfPropertyChanged("Special");
            }
        }

        private bool _lemon = false;
        public bool Lemon
        {
            get
            {
                return _lemon;
            }
            set
            {
                _lemon = value;
                NotifyOfPropertyChanged("Special");
            }
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
                if (!Ice) { special.Add("Hold Ice"); }
                if (Lemon) { special.Add("Add a Lemon"); }
                return special.ToArray();
            }
        }
    }
}
