﻿/*  TRexKingBurger.cs
 *  Author: John Chapple
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class TRexKingBurger contains all the information and methods for preparing a custom TRexKingBurger for the customer.
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// the below listed private bools resemble whether or not our object will have this ingredient
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

        /// <summary>
        /// public List<string> Ingredients adds all of the ingredients to our Item, dependent on our boolean flags above
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the default creation price and calories of a TRexKingBurger object
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public override string ToString()
        {
            return "T-Rex King Burger";
        }

        /// <summary>
        /// the below methods allow us to flag each of any of our ingredient booleans to remove the ingrdient from the item
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldMayo()
        {
            this.mayo = false;
            NotifyOfPropertyChanged("Special");
        }

        public override string Description
        {
            get
            {
                return "T-Rex King Burger";
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!this.bun) { special.Add("Hold Bun"); }
                if (!this.lettuce) { special.Add("Hold Lettuce"); }
                if (!this.tomato) { special.Add("Hold Tomato"); }
                if (!this.onion) { special.Add("Hold Onion"); }
                if (!this.pickle) { special.Add("Hold Pickle"); }
                if (!this.ketchup) { special.Add("Hold Ketchup"); }
                if (!this.mustard) { special.Add("Hold Mustard"); }
                if (!this.mayo) { special.Add("Hold Mayo"); }
                return special.ToArray();
            }
        }
    }
}
