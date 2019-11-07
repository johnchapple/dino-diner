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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Drink drink;
        public DrinkSelection()
        {
            InitializeComponent();
            EvaluateButtons();
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            EvaluateButtons();
        }

        private void chooseFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection(this.drink as Sodasaurus));
        }

        public void AddSodasaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.drink = new Sodasaurus();
                order.Add(this.drink);
                EvaluateButtons();
            }
        }

        public void AddTyrannotea(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.drink = new Tyrannotea();
                order.Add(this.drink);
                EvaluateButtons();
            }
        }

        public void AddJurassicJava(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.drink = new JurrasicJava();
                order.Add(this.drink);
                EvaluateButtons();
            }
        }

        public void AddWater(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.drink = new Water();
                order.Add(this.drink);
                EvaluateButtons();
            }
        }

        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                drink.Size = DinoDiner.Menu.Size.Large;
            }
        }

        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                drink.Size = DinoDiner.Menu.Size.Medium;
            }
        }

        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (drink != null)
            {
                drink.Size = DinoDiner.Menu.Size.Small;
            }
        }

        public void ToggleIce(object sender, RoutedEventArgs args)
        {
            {
                if (this.drink is JurrasicJava jj)
                {
                    jj.AddIce();
                }
                else
                {
                    this.drink.HoldIce();
                }
            }
        }

        public void Lemonize(object sender, RoutedEventArgs args)
        {
            {
                if (this.drink is Water w)
                {
                    w.AddLemon();
                }
                if (this.drink is Tyrannotea t)
                {
                    t.AddLemon();
                }
            }
        }

        public void ToggleDecaf(object sender, RoutedEventArgs args)
        {
            if (this.drink is JurrasicJava jj)
            {
                jj.Decaf = !jj.Decaf;
            }
        }

        public void LeaveRoomForCream(object sender, RoutedEventArgs args)
        {
            if (this.drink is JurrasicJava jj)
            {
                jj.LeaveRoomForCream();
            }
        }

        public void Sweeten(object sender, RoutedEventArgs args)
        {
            if (this.drink is Tyrannotea tt)
            {
                tt.Sweet = true;
            }
        }
        public void GoHome(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        public void EvaluateButtons()
        {
            Flavor.IsEnabled = false; Flavor.Visibility = Visibility.Hidden;
            Ice.IsEnabled = false; Ice.Visibility = Visibility.Hidden;
            Decaf.IsEnabled = false; Decaf.Visibility = Visibility.Hidden;
            Cream.IsEnabled = false; Cream.Visibility = Visibility.Hidden;
            Sweet.IsEnabled = false; Sweet.Visibility = Visibility.Hidden;
            Lemon.IsEnabled = false; Lemon.Visibility = Visibility.Hidden;

            if (this.drink is Sodasaurus) {
                Flavor.IsEnabled = true; Flavor.Visibility = Visibility.Visible;
                Ice.IsEnabled = true; Ice.Visibility = Visibility.Visible;
            }

            if (this.drink is JurrasicJava) {
                Decaf.IsEnabled = true; Decaf.Visibility = Visibility.Visible;
                Cream.IsEnabled = true; Cream.Visibility = Visibility.Visible;
                Ice.IsEnabled = true; Ice.Visibility = Visibility.Visible;
            }

            if (this.drink is Tyrannotea) {
                Sweet.IsEnabled = true; Sweet.Visibility = Visibility.Visible;
                Lemon.IsEnabled = true; Lemon.Visibility = Visibility.Visible;
            }

            if (this.drink is Water) {
                Ice.IsEnabled = true; Ice.Visibility = Visibility.Visible;
                Lemon.IsEnabled = true; Lemon.Visibility = Visibility.Visible;
            }
        }
    }
}
