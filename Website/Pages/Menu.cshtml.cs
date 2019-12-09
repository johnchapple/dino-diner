using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public static Menu menu { get; } = new Menu();

        public IEnumerable<IMenuItem> combos = menu.AvailableCombos;
        public IEnumerable<IMenuItem> entrees = menu.AvailableEntrees;
        public IEnumerable<IMenuItem> sides = menu.AvailableSides;
        public IEnumerable<IMenuItem> drinks = menu.AvailableDrinks;
        public IEnumerable<List<IMenuItem>> combosAll = menu.AvailableCombosAllSizes;
        public IEnumerable<List<IMenuItem>> sidesAll = menu.AvailableSidesAllSizes;
        public IEnumerable<List<IMenuItem>> drinksAll = menu.AvailableDrinksAllSizes;
        public List<String> ingredients = menu.PossibileIngredients;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> categories { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> inGredients { get; set; } = new List<string>();

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            combos = menu.AvailableCombos;
            entrees = menu.AvailableEntrees;
            sides = menu.AvailableSides;
            drinks = menu.AvailableDrinks;

            
            if (search != null)
            {
                combos = combos.Where(combo => combo.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                combosAll = combosAll.Where(combo => combo.ElementAt(0).Description.Contains(search, StringComparison.OrdinalIgnoreCase));

                entrees = entrees.Where(entree => entree.Description.Contains(search, StringComparison.OrdinalIgnoreCase));

                sides = sides.Where(side => side.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                sidesAll = sidesAll.Where(side => side.ElementAt(0).Description.Contains(search, StringComparison.OrdinalIgnoreCase));

                drinks = drinks.Where(drink => drink.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                drinksAll = drinksAll.Where(drink => drink.ElementAt(0).Description.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            

            
            if (minimumPrice != null) {
                combos = combos.Where(combo => combo.Price >= minimumPrice);
                combosAll = combosAll.Where(combo => combo.ElementAt(0).Price >= minimumPrice);

                entrees = entrees.Where(entree => entree.Price >= minimumPrice);

                sides = sides.Where(side => side.Price >= minimumPrice);
                sidesAll = sidesAll.Where(side => side.ElementAt(0).Price >= minimumPrice);

                drinks = drinks.Where(drink => drink.Price >= minimumPrice);
                drinksAll = drinksAll.Where(drink => drink.ElementAt(0).Price >= minimumPrice);
            }

            if (maximumPrice != null)
            {
                combos = combos.Where(combo => combo.Price <= maximumPrice);
                combosAll = combosAll.Where(combo => combo.ElementAt(0).Price <= maximumPrice);

                entrees = entrees.Where(entree => entree.Price <= maximumPrice);

                sides = sides.Where(side => side.Price <= maximumPrice);
                sidesAll = sidesAll.Where(side => side.ElementAt(0).Price <= maximumPrice);

                drinks = drinks.Where(drink => drink.Price <= maximumPrice);
                drinksAll = drinksAll.Where(drink => drink.ElementAt(0).Price <= maximumPrice);

            }

            if (categories.Count != 0)
            {
                if (!categories.Contains("Combo")) { combos = combos.Where(combo => (combo.Price == 45)); }
                if (!categories.Contains("Entree")) { entrees = entrees.Where(combo => (combo.Price == 45)); }
                if (!categories.Contains("Side")) { sides = sides.Where(combo => (combo.Price == 45)); }
                if (!categories.Contains("Drink")) { drinks = drinks.Where(combo => (combo.Price == 45)); }
            }
            
            if (inGredients != null)
            {
                foreach (string ingredient in inGredients)
                {
                    combos = combos.Where(combo => !combo.Ingredients.Contains(ingredient));
                    entrees = entrees.Where(entree => !entree.Ingredients.Contains(ingredient));
                    sides = sides.Where(side => !side.Ingredients.Contains(ingredient));
                    drinks = drinks.Where(drink => !drink.Ingredients.Contains(ingredient));
                }
            }
            /*
            if (minimumPrice is int min)
            {
                combos = new List<IMenuItem>();
                foreach (IMenuItem c in menu.AvailableCombos)
                {
                    if (c.Price >= min) { combos.Add(c); }
                }
                entrees = new List<IMenuItem>();
                foreach (IMenuItem c in menu.AvailableEntrees)
                {
                    if (c.Price >= min) { entrees.Add(c); }
                }
                sides = new List<IMenuItem>();
                foreach (IMenuItem c in menu.AvailableSides)
                {
                    if (c.Price >= min) { sides.Add(c); }
                }
                drinks = new List<IMenuItem>();
                foreach (IMenuItem c in menu.AvailableDrinks)
                {
                    if (c.Price >= min) { drinks.Add(c); }
                }
            }
            */
        }
    }
}