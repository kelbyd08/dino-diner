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
    public partial class CustomizeBrontowurst : Page
    {
        private PreviousPage page;
        private Brontowurst bw;
        private CretaceousCombo cmbo;
        public CustomizeBrontowurst(Brontowurst bw)
        {
            this.page = page;
            this.bw = bw;
            InitializeComponent();
        }

        public CustomizeBrontowurst( CretaceousCombo cmbo )
        {
            InitializeComponent();
            this.cmbo = cmbo;
            this.bw = cmbo.Entree as Brontowurst;
            ((Order)App.Current.MainWindow.DataContext).Items.Add(cmbo);
        }
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            bw.HoldBun();
        }
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            bw.HoldPeppers();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            bw.HoldOnion();
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
