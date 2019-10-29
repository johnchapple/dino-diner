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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            if (order != null)
            {
                order.Add(new DinoNuggets());
                order.Add(new Sodasaurus());
                order.Add(new Fryceritops());
                Triceritots tots = new Triceritots();
                tots.Size = DinoDiner.Menu.Size.Large;
                order.Add(tots);
                SteakosaurusBurger sb = new SteakosaurusBurger();
                sb.HoldMustard();
                order.Add(sb);

            }
        }
    }
}
