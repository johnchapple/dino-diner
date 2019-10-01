﻿/*  DinoNuggets.cs
 *  Author: John Chapple
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class DinoNuggets contains all the information and methods for preparing a custom DinoNuggets for the customer.
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// private uint nuggentCount will stand for how many nuggets will be in this item
        /// </summary>
        private uint nuggetCount = 6;

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
                List<string> ingredients = new List<string>();
                for (int nc = 0; nc < nuggetCount; nc++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the default creation price and calories of a DinoNuggets object
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * this.nuggetCount;
        }

        public override string ToString()
        {
            return "DinoNuggets";
        }

        /// <summary>
        /// public void AddNugget adds 1 to the nuggetCount, and increases the price variable accordingly
        /// </summary>
        public void AddNugget()
        {
            this.Price += .59;
            this.nuggetCount += 1;
        }
    }
}
