using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint nuggetCount = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int nc = 0; nc > nuggetCount; nc++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * this.nuggetCount;
        }

        public void AddNugget()
        {
            this.Price += .59;
            this.nuggetCount += 1;
            Ingredients.Add("Chicken Nugget");
        }
    }
}

}
