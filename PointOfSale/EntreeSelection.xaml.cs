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
        private void SwitchPage()
        {
            ((Order)App.Current.MainWindow.DataContext).Items.Add(DataContext as Entree);
            NavigationService.Navigate(new MenuCategorySelection());
        }
        private void BrontoClick(object sender, RoutedEventArgs args)
        {
            DataContext = new Brontowurst();
            SwitchPage();
        }
        private void DinoClick(object sender, RoutedEventArgs args)
        {
            DataContext = new DinoNuggets();
            SwitchPage();
        }
        private void PrehistoricClick(object sender, RoutedEventArgs args)
        {
            DataContext = new PrehistoricPBJ();
            SwitchPage();
        }
        private void PterodactylClick(object sender, RoutedEventArgs args)
        {
            DataContext = new PterodactylWings();
            SwitchPage();
        }
        private void SteakClick(object sender, RoutedEventArgs args)
        {
            DataContext = new SteakosaurusBurger();
            SwitchPage();
        }
        private void TRexClick(object sender, RoutedEventArgs args)
        {
            DataContext = new TRexKingBurger();
            SwitchPage();
        }
        private void VelociClick(object sender, RoutedEventArgs args)
        {
            DataContext = new VelociWrap();
            SwitchPage();
        }
    }

}
