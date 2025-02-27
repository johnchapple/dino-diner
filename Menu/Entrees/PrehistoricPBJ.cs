﻿using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;


        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Special");
        }

        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Special");
        }

        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        public override string Description
        {
            get
            {
                return "Prehistoric PB&J";
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!this.jelly) { special.Add("Hold Jelly"); }
                if (!this.peanutButter) { special.Add("Hold Peanut Butter"); }
                return special.ToArray();
            }
        }

        public override event PropertyChangedEventHandler PropertyChanged;

        protected override void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
