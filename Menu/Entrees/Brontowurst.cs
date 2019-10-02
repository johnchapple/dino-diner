/*  Brontowurst.cs
 *  Author: John Chapple
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Brontowurst contains all the information and methods for preparing a custom Brontowurst for the customer.
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// private bool Bun resembles whether or not the item will have a bun
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// private bool Peppers resembles whether or not the item will have peppers
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// private bool Onions resembles whether or not the item will have an onion
        /// </summary>
        private bool Onions = true;

        /// <summary>
        /// public List<string> Ingredients adds all of the ingredients to our Item, dependent on our boolean flags above
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the default creation price and calories of a Brontowurst object
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// public void HoldBun lets us remove the bun from the item
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }

        /// <summary>
        /// public void HoldBun lets us remove the peppers from the item
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
        }
        /// <summary>
        /// public void HoldBun lets us remove the onion from the item
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
        }
    }
}
