/*  PterodactlyWings.cs
 *  Author: John Chapple
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class PterodactylWings contains all the information and methods for preparing a custom PterodactylWings for the customer.
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// the below listed private bools resemble whether or not our object will have this ingredient
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// public List<string> Ingredients adds all of the ingredients to our Item, dependent on our boolean flags above
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the default creation price and calories of a PterodactylWings object
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        public override string ToString()
        {
            return "PterodactlyWings";
        }

        /// <summary>
        /// the below methods allow us to flag each of any of our ingredient booleans to remove the ingrdient from the item
        /// </summary>
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

        public override string Description
        {
            get
            {
                return "PterodactlyWings";
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!this.bun) { special.Add("Hold Bun "); }
                if (!this.peppers) { special.Add("Hold Peppers "); }
                if (!this.onions) { special.Add("Hold Onions "); }
                return special.ToArray();
            }
        }
    }
}
