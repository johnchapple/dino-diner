﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
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
    }
}
