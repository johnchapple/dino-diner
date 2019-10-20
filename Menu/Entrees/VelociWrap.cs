/*  Velociwrap.cs
 *  Author: John Chapple
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class VelociWrap contains all the information and methods for preparing a custom VelociWrap for the customer.
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// the below listed private bools resemble whether or not our object will have this ingredient
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// public List<string> Ingredients adds all of the ingredients to our Item, dependent on our boolean flags above
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the default creation price and calories of a VelociWrap object
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public override string ToString()
        {
            return "VelociWrap";
        }

        /// <summary>
        /// the below methods allow us to flag each of any of our ingredient booleans to remove the ingrdient from the item
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
        }
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChanged("Special");
        }

        public override string Description
        {
            get
            {
                return "VelociWrap";
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!this.dressing) { special.Add("Hold Dressing"); }
                if (!this.lettuce) { special.Add("Hold Lettuce"); }
                if (!this.cheese) { special.Add("Hold Cheese"); }
                return special.ToArray();
            }
        }
    }
}
