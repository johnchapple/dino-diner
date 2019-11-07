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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        public void BrontoCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst bw = new Brontowurst();
                CretaceousCombo c = new CretaceousCombo(bw);
                order.Add(c);
                NavigationService.Navigate(new ComboCustomize(c));
            }
        }

        public void SteakCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger bw = new SteakosaurusBurger();
                CretaceousCombo c = new CretaceousCombo(bw);
                order.Add(c);
                NavigationService.Navigate(new ComboCustomize(c));
            }
        }

        public void TRexCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger bw = new TRexKingBurger();
                CretaceousCombo c = new CretaceousCombo(bw);
                order.Add(c);
                NavigationService.Navigate(new ComboCustomize(c));
            }
        }

        public void PrehistoricCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ bw = new PrehistoricPBJ();
                CretaceousCombo c = new CretaceousCombo(bw);
                order.Add(c);
                NavigationService.Navigate(new ComboCustomize(c));
            }
        }

        public void PterCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PterodactylWings bw = new PterodactylWings();
                CretaceousCombo c = new CretaceousCombo(bw);
                order.Add(c);
                NavigationService.Navigate(new ComboCustomize(c));
            }
        }

        public void VelociCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap bw = new VelociWrap();
                CretaceousCombo c = new CretaceousCombo(bw);
                order.Add(c);
                NavigationService.Navigate(new ComboCustomize(c));
            }
        }

        public void NuggetsCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets bw = new DinoNuggets();
                CretaceousCombo c = new CretaceousCombo(bw);
                order.Add(c);
                NavigationService.Navigate(new ComboCustomize(c));
            }
        }
    }
}
