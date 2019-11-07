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
    /// Interaction logic for CustomisePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizeSteakosaurus : Page
    {
        private PreviousPage page;
        private SteakosaurusBurger bgr;
        private CretaceousCombo cmbo;
        public CustomizeSteakosaurus(SteakosaurusBurger bgr)
        {
            this.page = page;
            this.bgr = bgr;
            InitializeComponent();
        }

        public CustomizeSteakosaurus( CretaceousCombo cmbo )
        {
            InitializeComponent();
            this.cmbo = cmbo;
            bgr = cmbo.Entree as SteakosaurusBurger;
            ((Order)App.Current.MainWindow.DataContext).Items.Add(cmbo);
        }
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            bgr.HoldBun();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            bgr.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            bgr.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            bgr.HoldMustard();
        }
        private void OnDone(object secnder, RoutedEventArgs args)
        {
            if( cmbo != null)
                NavigationService.Navigate(new CustomizeCombo(cmbo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
