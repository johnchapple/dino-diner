using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
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
                    case Size.Small: { Price = 0.99; Calories = 8; } break;
                    case Size.Medium: { Price = 1.49; Calories = 16; } break;
                    case Size.Large: { Price = 1.99; Calories = 32; } break;
                }
                if (Sweet) { Calories *= 2; }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> newIngredients = new List<string>();
                newIngredients.Add("Water");
                newIngredients.Add("Tea");
                if (Lemon) { newIngredients.Add("Lemon"); }
                if (Sweet) { newIngredients.Add("Cane Sugar"); }
                return newIngredients;
            }
        }
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            Sweet = false;
            Lemon = false;
        }
        public override string ToString()
        {
            return "Tyrannotea";
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public override bool Ice { get; set; }
        public bool Sweet { get; set; }
        public bool Lemon { get; set; }
        public override string Description
        {
            get
            {
                return "Tyrannotea";
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice) { special.Add("Add Ice "); }
                if (Sweet) { special.Add("Add Sugar "); }
                if (Lemon) { special.Add("Add a Lemon"); }
                return special.ToArray();
            }
        }
    }
}
