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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus drink;
        public FlavorSelection(Sodasaurus drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        public void cherryFlavor(object sender, RoutedEventArgs args) { drink.Flavor = SodasaurusFlavor.Cherry; NavigationService.Navigate(new MenuCategorySelection()); }
        public void limeFlavor(object sender, RoutedEventArgs args) { drink.Flavor = SodasaurusFlavor.Lime; NavigationService.Navigate(new MenuCategorySelection()); }
        public void chocolateFlavor(object sender, RoutedEventArgs args) { drink.Flavor = SodasaurusFlavor.Chocolate; NavigationService.Navigate(new MenuCategorySelection()); }
        public void orangeFlavor(object sender, RoutedEventArgs args) { drink.Flavor = SodasaurusFlavor.Orange; NavigationService.Navigate(new MenuCategorySelection()); }
        public void colaFlavor(object sender, RoutedEventArgs args) { drink.Flavor = SodasaurusFlavor.Cola; NavigationService.Navigate(new MenuCategorySelection()); }
        public void rootbeerFlavor(object sender, RoutedEventArgs args) { drink.Flavor = SodasaurusFlavor.RootBeer; NavigationService.Navigate(new MenuCategorySelection()); }
        public void vanillaFlavor(object sender, RoutedEventArgs args) { drink.Flavor = SodasaurusFlavor.Vanilla; NavigationService.Navigate(new MenuCategorySelection()); }

    }
}
