using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeCustomize.xaml
    /// </summary>
    public partial class EntreeCustomize : Page
    {
        private Entree entree;

        public EntreeCustomize(Entree entree)
        {
            InitializeComponent();
            this.entree = entree;
            EvaluateButtons();
        }

        public void HoldOnions(object sender, RoutedEventArgs args)
        {
            if (this.entree is Brontowurst e) { e.HoldOnion(); }
            if (this.entree is PterodactylWings ee) { ee.HoldOnion(); }
            if (this.entree is TRexKingBurger eee) { eee.HoldOnion(); }
        }

        public void HoldPeppers(object sender, RoutedEventArgs args)
        {
            if (this.entree is Brontowurst e) { e.HoldPeppers(); }
            if (this.entree is PterodactylWings ee) { ee.HoldPeppers(); }
        }

        public void HoldBun(object sender, RoutedEventArgs args)
        {
            if (this.entree is Brontowurst e) { e.HoldBun(); }
            if (this.entree is PterodactylWings ee) { ee.HoldBun(); }
            if (this.entree is SteakosaurusBurger eee) { eee.HoldBun(); }
            if (this.entree is SteakosaurusBurger eeee) { eeee.HoldBun(); }
        }
        public void AddNugget(object sender, RoutedEventArgs args)
        {
            if (this.entree is DinoNuggets e) { e.AddNugget(); }
        }
        public void HoldJelly(object sender, RoutedEventArgs args)
        {
            if (this.entree is PrehistoricPBJ e) { e.HoldJelly(); }
        }
        public void HoldPeanutButter(object sender, RoutedEventArgs args)
        {
            if (this.entree is PrehistoricPBJ e) { e.HoldPeanutButter(); }
        }
        public void HoldPickles(object sender, RoutedEventArgs args)
        {
            if (this.entree is SteakosaurusBurger e) { e.HoldPickle(); }
            if (this.entree is TRexKingBurger ee) { ee.HoldPickle(); }
        }
        public void HoldKetchup(object sender, RoutedEventArgs args)
        {
            if (this.entree is SteakosaurusBurger e) { e.HoldKetchup(); }
            if (this.entree is TRexKingBurger ee) { ee.HoldKetchup(); }
        }
        public void HoldMustard(object sender, RoutedEventArgs args)
        {
            if (this.entree is SteakosaurusBurger e) { e.HoldMustard(); }
            if (this.entree is TRexKingBurger ee) { ee.HoldMustard(); }
        }
        public void HoldMayo(object sender, RoutedEventArgs args)
        {
            if (this.entree is TRexKingBurger e) { e.HoldMayo(); }
        }
        public void HoldTomato(object sender, RoutedEventArgs args)
        {
            if (this.entree is TRexKingBurger e) { e.HoldTomato(); }
        }
        public void HoldLettuce(object sender, RoutedEventArgs args)
        {
            if (this.entree is TRexKingBurger e) { e.HoldLettuce(); }
        }
        public void HoldDressing(object sender, RoutedEventArgs args)
        {
            if (this.entree is VelociWrap e) { e.HoldDressing(); }
        }
        public void HoldCheese(object sender, RoutedEventArgs args)
        {
            if (this.entree is VelociWrap e) { e.HoldCheese(); }
        }
        public void GoHome(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        public void EvaluateButtons()
        {
            Onions.IsEnabled = false; Onions.Visibility = Visibility.Hidden;
            Peppers.IsEnabled = false; Peppers.Visibility = Visibility.Hidden;
            Bun.IsEnabled = false; Bun.Visibility = Visibility.Hidden;

            Nuggets.IsEnabled = false; Nuggets.Visibility = Visibility.Hidden;
            Jelly.IsEnabled = false; Jelly.Visibility = Visibility.Hidden;
            PeanutButter.IsEnabled = false; PeanutButter.Visibility = Visibility.Hidden;

            Pickles.IsEnabled = false; Pickles.Visibility = Visibility.Hidden;
            Ketchup.IsEnabled = false; Ketchup.Visibility = Visibility.Hidden;
            Mustard.IsEnabled = false; Mustard.Visibility = Visibility.Hidden;

            Mayo.IsEnabled = false; Mayo.Visibility = Visibility.Hidden;
            Tomato.IsEnabled = false; Tomato.Visibility = Visibility.Hidden;
            Lettuce.IsEnabled = false; Lettuce.Visibility = Visibility.Hidden;

            Dressing.IsEnabled = false; Dressing.Visibility = Visibility.Hidden;
            Cheese.IsEnabled = false; Cheese.Visibility = Visibility.Hidden;

            if (this.entree is Brontowurst)
            {
                Onions.IsEnabled = true; Onions.Visibility = Visibility.Visible;
                Peppers.IsEnabled = true; Peppers.Visibility = Visibility.Visible;
                Bun.IsEnabled = true; Bun.Visibility = Visibility.Visible;
            }
            if (this.entree is DinoNuggets)
            {
                Nuggets.IsEnabled = true; Nuggets.Visibility = Visibility.Visible;
            }
            if (this.entree is PrehistoricPBJ)
            {
                Jelly.IsEnabled = true; Jelly.Visibility = Visibility.Visible;
                PeanutButter.IsEnabled = true; PeanutButter.Visibility = Visibility.Visible;
            }
            if (this.entree is PterodactylWings)
            {
                Onions.IsEnabled = true; Onions.Visibility = Visibility.Visible;
                Peppers.IsEnabled = true; Peppers.Visibility = Visibility.Visible;
                Bun.IsEnabled = true; Bun.Visibility = Visibility.Visible;
            }
            if (this.entree is SteakosaurusBurger)
            {
                Bun.IsEnabled = true; Bun.Visibility = Visibility.Visible;
                Pickles.IsEnabled = true; Pickles.Visibility = Visibility.Visible;
                Ketchup.IsEnabled = true; Ketchup.Visibility = Visibility.Visible;
                Mustard.IsEnabled = true; Mustard.Visibility = Visibility.Visible;
            }
            if (this.entree is TRexKingBurger)
            {
                Bun.IsEnabled = true; Bun.Visibility = Visibility.Visible;
                Pickles.IsEnabled = true; Pickles.Visibility = Visibility.Visible;
                Ketchup.IsEnabled = true; Ketchup.Visibility = Visibility.Visible;
                Mustard.IsEnabled = true; Mustard.Visibility = Visibility.Visible;
                Mayo.IsEnabled = true; Mayo.Visibility = Visibility.Visible;
                Lettuce.IsEnabled = true; Lettuce.Visibility = Visibility.Visible;
                Tomato.IsEnabled = true; Tomato.Visibility = Visibility.Visible;
                Onions.IsEnabled = true; Onions.Visibility = Visibility.Visible;
            }
            if (this.entree is VelociWrap)
            {
                Cheese.IsEnabled = true; Cheese.Visibility = Visibility.Visible;
                Dressing.IsEnabled = true; Dressing.Visibility = Visibility.Visible;
            }
        }
    }
}
