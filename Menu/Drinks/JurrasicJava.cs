using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurrasicJava : Drink
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
                    case Size.Small: { Price = 0.59; Calories = 2; } break;
                    case Size.Medium: { Price = 0.99; Calories = 4; } break;
                    case Size.Large: { Price = 1.49; Calories = 8; } break;
                }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> newIngredients = new List<string>();
                newIngredients.Add("Water");
                newIngredients.Add("Coffee");
                return newIngredients;
            }
        }
        public JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;
            Ice = false;
            Decaf = false;
            RoomForCream = false;
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }

        public override bool Ice { get; set; }
        public bool Decaf { get; set; }
        public bool RoomForCream { get; set; }

        public override string ToString()
        {
            return "JurrasicJava";
        }
    }
}
