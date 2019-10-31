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
                order.Add(new Brontowurst());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new DinoNuggets());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new PrehistoricPBJ());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new PterodactylWings());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new SteakosaurusBurger());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new TRexKingBurger());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                order.Add(new VelociWrap());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
