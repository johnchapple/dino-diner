using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        // Backing Variables
        private Size size;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Entree _entree;
        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return _entree;
            }
            set
            {
                _entree = value;
                NotifyOfPropertyChanged("Special");
                _entree.PropertyChanged += ConstituentListener;
            }
        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        private Side _side;
        public Side Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
                _side.Size = Size;
                NotifyOfPropertyChanged("Special");
                _side.PropertyChanged += ConstituentListener;
            }
        }

        private void ConstituentListener(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChanged("Special");
        }

        private Drink _drink;
        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return _drink;
            }
            set
            {
                _drink = value;
                _drink.Size = Size;
                NotifyOfPropertyChanged("Special");
                _drink.PropertyChanged += ConstituentListener;
            }
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        
        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
        }

        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                specials.Add(Entree.Description);
                specials.AddRange(Entree.Special);
                specials.Add(Side.Description);
                specials.AddRange(Side.Special);
                specials.Add(Drink.Description);
                specials.AddRange(Drink.Special);
                return specials.ToArray();
            }
        }

        public string Description
        {
            get
            {
                return $"{Entree.Description} Combo";
            }
        }

        public string ToString()
        {
            return $"{Entree} Combo";
        }
    }
}
