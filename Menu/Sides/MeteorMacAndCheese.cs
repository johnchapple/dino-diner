﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
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
                    case Size.Small: { Price = .99; Calories = 420; } break;
                    case Size.Medium: { Price = 1.45; Calories = 490; } break;
                    case Size.Large: { Price = 1.95; Calories = 520; } break;
                }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> newIngredients = new List<string>();
                newIngredients.Add("Macaroni Noodles");
                newIngredients.Add("Cheese Product");
                newIngredients.Add("Pork Sausage");
                return newIngredients;
            }
        }
        public MeteorMacAndCheese()
        {
            Price = .99;
            Calories = 420;
        }

        public override string ToString()
        {
            return "MeteorMacAndCheese";
        }
    }
}
