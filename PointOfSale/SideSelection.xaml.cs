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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;
        private CretaceousCombo combo;

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }
        public SideSelection(CretaceousCombo c)
        {
            InitializeComponent();
            this.combo = c;
        }

        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.side = new Fryceritops();
                if (this.combo != null) { combo.Side = this.side; } else { order.Add(this.side); }
            }
        }

        public void AddMeteor(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.side = new MeteorMacAndCheese();
                if (this.combo != null) { combo.Side = this.side; } else { order.Add(this.side); }
            }
        }

        public void AddMezz(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.side = new MezzorellaSticks();
                if (this.combo != null) { combo.Side = this.side; } else { order.Add(this.side); }
            }
        }

        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.side = new Triceritots();
                if (this.combo != null) { combo.Side = this.side; } else { order.Add(this.side); }
            }
        }

        public void MakeLarge(object sender, RoutedEventArgs args)
        {
            if (side != null)
            {
                side.Size = DinoDiner.Menu.Size.Large;
            }
        }

        public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (side != null)
            {
                side.Size = DinoDiner.Menu.Size.Medium;
            }
        }

        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (side != null)
            {
                side.Size = DinoDiner.Menu.Size.Small;
            }
        }

        public void GoHome(object sender, RoutedEventArgs args)
        {
            if (this.combo != null) { NavigationService.Navigate(new ComboCustomize(this.combo)); } else { NavigationService.Navigate(new MenuCategorySelection()); }
        }
    }
}
