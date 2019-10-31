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
        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }

        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.side = new Fryceritops();
                order.Add(this.side);
            }
        }

        public void AddMeteor(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.side = new MeteorMacAndCheese();
                order.Add(this.side);
            }
        }

        public void AddMezz(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.side = new MezzorellaSticks();
                order.Add(this.side);
            }
        }

        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                this.side = new Triceritots();
                order.Add(this.side);
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
    }
}
