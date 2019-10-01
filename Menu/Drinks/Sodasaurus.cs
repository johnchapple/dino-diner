﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
            Price = 1.50;
            Calories = 112;
        }

        public override string ToString()
        {
            return "Sodasaurus";
        }

        public override bool Ice { get; set; }

        public SodasaurusFlavor Flavor;
    }
}
