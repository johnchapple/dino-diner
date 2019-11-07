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
    /// Interaction logic for ComboCustomize.xaml
    /// </summary>
    public partial class ComboCustomize : Page
    {
        private CretaceousCombo combo;
        public ComboCustomize(CretaceousCombo c)
        {
            InitializeComponent();
            combo = c;
        }
        private void MakeSmall(object sender, RoutedEventArgs e)
        {
            this.combo.Size = DinoDiner.Menu.Size.Small;
        }
        private void MakeMedium(object sender, RoutedEventArgs e)
        {
            this.combo.Size = DinoDiner.Menu.Size.Medium;
        }
        private void MakeLarge(object sender, RoutedEventArgs e)
        {
            this.combo.Size = DinoDiner.Menu.Size.Large;
        }
        private void ChooseSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(this.combo));
        }

        private void ChooseDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(this.combo));
        }
    }
}
