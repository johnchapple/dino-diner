using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menulist = new List<IMenuItem>();

                menulist.Add(new JurassicJava());
                menulist.Add(new Sodasaurus());
                menulist.Add(new Tyrannotea());
                menulist.Add(new Water());

                menulist.Add(new Brontowurst());
                menulist.Add(new DinoNuggets());
                menulist.Add(new PrehistoricPBJ());
                menulist.Add(new PterodactylWings());
                menulist.Add(new SteakosaurusBurger());
                menulist.Add(new TRexKingBurger());
                menulist.Add(new VelociWrap());

                menulist.Add(new Fryceritops());
                menulist.Add(new MeteorMacAndCheese());
                menulist.Add(new MezzorellaSticks());
                menulist.Add(new Triceritots());

                menulist.Add(new CretaceousCombo(new Brontowurst()));
                menulist.Add(new CretaceousCombo(new DinoNuggets()));
                menulist.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menulist.Add(new CretaceousCombo(new PterodactylWings()));
                menulist.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menulist.Add(new CretaceousCombo(new TRexKingBurger()));
                menulist.Add(new CretaceousCombo(new VelociWrap()));

                return menulist;
            }
        }

        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> menulist = new List<IMenuItem>();
                menulist.Add(new Fryceritops());
                menulist.Add(new MeteorMacAndCheese());
                menulist.Add(new MezzorellaSticks());
                menulist.Add(new Triceritots());
                return menulist;
            }
        }

        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> menulist = new List<IMenuItem>();
                menulist.Add(new JurassicJava());
                menulist.Add(new Sodasaurus());
                menulist.Add(new Tyrannotea());
                menulist.Add(new Water());
                return menulist;
            }
        }

        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> menulist = new List<IMenuItem>();
                menulist.Add(new CretaceousCombo(new Brontowurst()));
                menulist.Add(new CretaceousCombo(new DinoNuggets()));
                menulist.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menulist.Add(new CretaceousCombo(new PterodactylWings()));
                menulist.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menulist.Add(new CretaceousCombo(new TRexKingBurger()));
                menulist.Add(new CretaceousCombo(new VelociWrap()));
                return menulist;
            }
        }

        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> menulist = new List<IMenuItem>();
                menulist.Add(new Brontowurst());
                menulist.Add(new DinoNuggets());
                menulist.Add(new PrehistoricPBJ());
                menulist.Add(new PterodactylWings());
                menulist.Add(new SteakosaurusBurger());
                menulist.Add(new TRexKingBurger());
                menulist.Add(new VelociWrap());
                return menulist;
            }
        }

        public override string ToString()
        {
            string menu = "";
            foreach (IMenuItem i in AvailableMenuItems)
            {
                menu += i.ToString() + "\n";
            }
            return menu;
        }
    }
}
