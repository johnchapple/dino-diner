using System;
using System.Collections.Generic;
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
            Ice = true;
            Lemon = false;
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public override string ToString()
        {
            return "Water";
        }

        public override bool Ice { get; set; }
        public bool Lemon { get; set; }

        public override string Description
        {
            get
            {
                return "Water";
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice) { special.Add("Add Ice "); }
                if (Lemon) { special.Add("Add a Lemon "); }
                return special.ToArray();
            }
        }
    }
}
