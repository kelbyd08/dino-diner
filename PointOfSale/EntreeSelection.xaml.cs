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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public EntreeSelection()
        {
            InitializeComponent();
        }
        private void SwitchPage(int type)
        {
            ((Order)App.Current.MainWindow.DataContext).Items.Add(DataContext as Entree);
            switch( type )
            {
                case 0:
                    NavigationService.Navigate(new CustomizeBrontowurst(DataContext as Brontowurst));
                    break;
                case 1:
                    NavigationService.Navigate(new CustomizeDinonuggets(DataContext as DinoNuggets));

                    break;
                case 2:
                    NavigationService.Navigate(new CustomisePrehistoricPBJ(DataContext as PrehistoricPBJ));

                    break;
                case 3:
                    NavigationService.Navigate(new MenuCategorySelection());
                    break;
                case 4:
                    NavigationService.Navigate(new CustomizeSteakosaurus(DataContext as SteakosaurusBurger));
                    break;
                case 5:
                    NavigationService.Navigate(new CustomizeTRex(DataContext as TRexKingBurger));
                    break;
                case 6:
                    NavigationService.Navigate(new CustomizeVelociwrap(DataContext as VelociWrap));
                    break;
            }
        }
        private void BrontoClick(object sender, RoutedEventArgs args)
        {
            DataContext = new Brontowurst();
            SwitchPage(0);
        }
        private void DinoClick(object sender, RoutedEventArgs args)
        {
            DataContext = new DinoNuggets();
            SwitchPage(1);
        }
        private void PrehistoricClick(object sender, RoutedEventArgs args)
        {
            DataContext = new PrehistoricPBJ();
            SwitchPage(2);
        }
        private void PterodactylClick(object sender, RoutedEventArgs args)
        {
            DataContext = new PterodactylWings();
            SwitchPage(3);
        }
        private void SteakClick(object sender, RoutedEventArgs args)
        {
            DataContext = new SteakosaurusBurger();
            SwitchPage(4);
        }
        private void TRexClick(object sender, RoutedEventArgs args)
        {
            DataContext = new TRexKingBurger();
            SwitchPage(5);
        }
        private void VelociClick(object sender, RoutedEventArgs args)
        {
            DataContext = new VelociWrap();
            SwitchPage(6);
        }
    }

}
