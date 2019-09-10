using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
