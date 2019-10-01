/*  SteakosaurusBurger.cs
 *  Author: John Chapple
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class SteakosaurusBurger contains all the information and methods for preparing a custom SteakosaurusBurger for the customer.
    /// </summary>
    public class SteakosaurusBurger
    {
        /// <summary>
        /// the below listed private bools resemble whether or not our object will have this ingredient
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// public double Price lets us access and change the price of the class
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// public unit Calories lets us access and change the calories of the class
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// public List<string> Ingredients adds all of the ingredients to our Item, dependent on our boolean flags above
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the default creation price and calories of a SteakosaurusBurger object
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public override string ToString()
        {
            return "SteakosaurusBurger";
        }

        /// <summary>
        /// the below methods allow us to flag each of any of our ingredient booleans to remove the ingrdient from the item
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
