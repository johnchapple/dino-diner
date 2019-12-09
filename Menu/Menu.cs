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

        public List<List<IMenuItem>> AvailableCombosAllSizes
        {
            get
            {
                List<List<IMenuItem>> menulist = new List<List<IMenuItem>>();

                List<IMenuItem> a = new List<IMenuItem>();
                CretaceousCombo aa = new CretaceousCombo(new Brontowurst()); aa.Size = Size.Small;
                a.Add(aa);
                CretaceousCombo bb = new CretaceousCombo(new Brontowurst()); bb.Size = Size.Medium;
                a.Add(bb);
                CretaceousCombo cc = new CretaceousCombo(new Brontowurst()); cc.Size = Size.Large;
                a.Add(cc);
                menulist.Add(a);

                List<IMenuItem> b = new List<IMenuItem>();
                CretaceousCombo dd = new CretaceousCombo(new DinoNuggets()); dd.Size = Size.Small;
                b.Add(dd);
                CretaceousCombo ee = new CretaceousCombo(new DinoNuggets()); ee.Size = Size.Medium;
                b.Add(ee);
                CretaceousCombo ff = new CretaceousCombo(new DinoNuggets()); ff.Size = Size.Large;
                b.Add(ff);
                menulist.Add(b);

                List<IMenuItem> c = new List<IMenuItem>();
                CretaceousCombo gg = new CretaceousCombo(new PrehistoricPBJ()); gg.Size = Size.Small;
                c.Add(gg);
                CretaceousCombo hh = new CretaceousCombo(new PrehistoricPBJ()); hh.Size = Size.Medium;
                c.Add(hh);
                CretaceousCombo ii = new CretaceousCombo(new PrehistoricPBJ()); ii.Size = Size.Large;
                c.Add(ii);
                menulist.Add(c);

                List<IMenuItem> d = new List<IMenuItem>();
                CretaceousCombo jj = new CretaceousCombo(new PterodactylWings()); jj.Size = Size.Small;
                d.Add(jj);
                CretaceousCombo kk = new CretaceousCombo(new PterodactylWings()); kk.Size = Size.Medium;
                d.Add(kk);
                CretaceousCombo ll = new CretaceousCombo(new PterodactylWings()); ll.Size = Size.Large;
                d.Add(ll);
                menulist.Add(d);

                List<IMenuItem> e = new List<IMenuItem>();
                CretaceousCombo mm = new CretaceousCombo(new SteakosaurusBurger()); mm.Size = Size.Small;
                e.Add(mm);
                CretaceousCombo nn = new CretaceousCombo(new SteakosaurusBurger()); nn.Size = Size.Medium;
                e.Add(nn);
                CretaceousCombo oo = new CretaceousCombo(new SteakosaurusBurger()); oo.Size = Size.Large;
                e.Add(oo);
                menulist.Add(e);

                List<IMenuItem> f = new List<IMenuItem>();
                CretaceousCombo pp = new CretaceousCombo(new TRexKingBurger()); pp.Size = Size.Small;
                f.Add(pp);
                CretaceousCombo qq = new CretaceousCombo(new TRexKingBurger()); qq.Size = Size.Medium;
                f.Add(qq);
                CretaceousCombo rr = new CretaceousCombo(new TRexKingBurger()); rr.Size = Size.Large;
                f.Add(rr);
                menulist.Add(f);

                List<IMenuItem> g = new List<IMenuItem>();
                CretaceousCombo ss = new CretaceousCombo(new VelociWrap()); ss.Size = Size.Small;
                g.Add(ss);
                CretaceousCombo tt = new CretaceousCombo(new VelociWrap()); tt.Size = Size.Medium;
                g.Add(tt);
                CretaceousCombo uu = new CretaceousCombo(new VelociWrap()); uu.Size = Size.Large;
                g.Add(uu);
                menulist.Add(g);

                return menulist;
            }
        }

        public List<List<IMenuItem>> AvailableSidesAllSizes
        {
            get
            {
                List<List<IMenuItem>> menulist = new List<List<IMenuItem>>();

                List<IMenuItem> a = new List<IMenuItem>();
                Fryceritops aa = new Fryceritops(); aa.Size = Size.Small;
                a.Add(aa);
                Fryceritops bb = new Fryceritops(); bb.Size = Size.Medium;
                a.Add(bb);
                Fryceritops cc = new Fryceritops(); cc.Size = Size.Large;
                a.Add(cc);
                menulist.Add(a);

                List<IMenuItem> b = new List<IMenuItem>();
                MeteorMacAndCheese dd = new MeteorMacAndCheese(); dd.Size = Size.Small;
                b.Add(dd);
                MeteorMacAndCheese ee = new MeteorMacAndCheese(); ee.Size = Size.Medium;
                b.Add(ee);
                MeteorMacAndCheese ff = new MeteorMacAndCheese(); ff.Size = Size.Large;
                b.Add(ff);
                menulist.Add(b);

                List<IMenuItem> c = new List<IMenuItem>();
                MezzorellaSticks gg = new MezzorellaSticks(); gg.Size = Size.Small;
                c.Add(gg);
                MezzorellaSticks hh = new MezzorellaSticks(); hh.Size = Size.Medium;
                c.Add(hh);
                MezzorellaSticks ii = new MezzorellaSticks(); ii.Size = Size.Large;
                c.Add(ii);
                menulist.Add(c);

                List<IMenuItem> d = new List<IMenuItem>();
                Triceritots jj = new Triceritots(); jj.Size = Size.Small;
                d.Add(jj);
                Triceritots kk = new Triceritots(); kk.Size = Size.Medium;
                d.Add(kk);
                Triceritots ll = new Triceritots(); ll.Size = Size.Large;
                d.Add(ll);
                menulist.Add(d);


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

        public List<List<IMenuItem>> AvailableDrinksAllSizes
        {
            get
            {
                List<List<IMenuItem>> menulist = new List<List<IMenuItem>>();

                List<IMenuItem> a = new List<IMenuItem>();
                JurassicJava aa = new JurassicJava(); aa.Size = Size.Small;
                a.Add(aa);
                JurassicJava bb = new JurassicJava(); bb.Size = Size.Medium;
                a.Add(bb);
                JurassicJava cc = new JurassicJava(); cc.Size = Size.Large;
                a.Add(cc);
                menulist.Add(a);

                List<IMenuItem> b = new List<IMenuItem>();
                Sodasaurus dd = new Sodasaurus(); dd.Size = Size.Small;
                b.Add(dd);
                Sodasaurus ee = new Sodasaurus(); ee.Size = Size.Medium;
                b.Add(ee);
                Sodasaurus ff = new Sodasaurus(); ff.Size = Size.Large;
                b.Add(ff);
                menulist.Add(b);

                List<IMenuItem> c = new List<IMenuItem>();
                Tyrannotea gg = new Tyrannotea(); gg.Size = Size.Small;
                c.Add(gg);
                Tyrannotea hh = new Tyrannotea(); hh.Size = Size.Medium;
                c.Add(hh);
                Tyrannotea ii = new Tyrannotea(); ii.Size = Size.Large;
                c.Add(ii);
                menulist.Add(c);

                List<IMenuItem> d = new List<IMenuItem>();
                Water jj = new Water(); jj.Size = Size.Small;
                d.Add(jj);
                Water kk = new Water(); kk.Size = Size.Medium;
                d.Add(kk);
                Water ll = new Water(); ll.Size = Size.Large;
                d.Add(ll);
                menulist.Add(d);


                return menulist;
            }
        }

        public List<String> PossibileIngredients
        {
            get
            {
                List<String> i = new List<String>();
                i.Add("Whole Wheat Bun");
                i.Add("Peppers");
                i.Add("Onion");
                i.Add("Chicken Nugget");
                i.Add("Bread");
                i.Add("Peanut Butter");
                i.Add("Jelly");
                i.Add("Chicken");
                i.Add("Wing Sauce");
                i.Add("Steakburger Pattie");
                i.Add("Pickle");
                i.Add("Mustard");
                i.Add("Ketchup");
                i.Add("Lettuce");
                i.Add("Tomato");
                i.Add("Mayo");
                i.Add("Flour Tortilla");
                i.Add("Chicken Breast");
                i.Add("Ceasar Dressing");
                i.Add("Romaine Lettuce");
                i.Add("Parmesan Cheese");
                i.Add("Potato");
                i.Add("Salt");
                i.Add("Vegetable Oil");
                i.Add("Macaroni Noodles");
                i.Add("Cheese Product");
                i.Add("Pork Sausage");
                i.Add("Breading");
                i.Add("Water");
                i.Add("Coffee");
                i.Add("Cane Sugar");
                i.Add("Tea");
                i.Add("Lemon");
                i.Add("Cane Sugar");
                return i;
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
