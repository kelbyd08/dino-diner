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
    public partial class CustomizeTRex : Page
    {
        private PreviousPage page;
        private TRexKingBurger trex;
        private CretaceousCombo cmbo;
        public CustomizeTRex(TRexKingBurger trex)
        {
            this.page = page;
            this.trex = trex;
            InitializeComponent();
        }

        public CustomizeTRex( CretaceousCombo cmbo )
        {
            InitializeComponent();
            this.cmbo = cmbo;
            this.trex = cmbo.Entree as TRexKingBurger;
            ((Order)App.Current.MainWindow.DataContext).Items.Add(cmbo);
        }
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            trex.HoldBun();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trex.HoldLettuce();
        }
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trex.HoldTomato();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trex.HoldOnion();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trex.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trex.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trex.HoldMustard();
        }
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trex.HoldMayo();
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
