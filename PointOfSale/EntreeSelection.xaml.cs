using DinoDiner.Menu;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
        {
            InitializeComponent();

        }

        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst entree = new Brontowurst();
                order.Add(entree);
                NavigationService.Navigate(new EntreeCustomize(entree));
            }
        }

        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new EntreeCustomize(entree));
            }
        }

        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new EntreeCustomize(entree));
            }
        }

        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new EntreeCustomize(entree));
            }
        }

        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new EntreeCustomize(entree));
            }
        }

        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new EntreeCustomize(entree));
            }
        }

        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new EntreeCustomize(entree));
            }
        }
    }
}
