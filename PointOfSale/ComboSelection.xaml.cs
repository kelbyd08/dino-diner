/*  ComboSelection.xaml.cs
*   Author: Kelby Dinkel
*/
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

        /// <summary>
        /// Click handler for any combo button. 
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void CustomizeCombo(object sender, RoutedEventArgs e)
        {
            switch(((Button)sender).Tag)
            {
                case "0":
                    NavigationService.Navigate(new CustomizeBrontowurst( new CretaceousCombo(new Brontowurst())));
                    break;
                case "1":
                    NavigationService.Navigate(new CustomizeDinonuggets(new CretaceousCombo(new DinoNuggets())));
                    break;
                case "2":
                    NavigationService.Navigate(new CustomizeSteakosaurus(new CretaceousCombo(new SteakosaurusBurger())));
                    break;
                case "3":
                    NavigationService.Navigate(new CustomizeTRex(new CretaceousCombo(new TRexKingBurger())));
                    break;
                case "4":
                    NavigationService.Navigate(new CustomisePrehistoricPBJ(new CretaceousCombo(new PrehistoricPBJ())));
                    break;
                case "5":
                    CretaceousCombo cmbo = new CretaceousCombo(new PterodactylWings());
                    ((Order)App.Current.MainWindow.DataContext).Items.Add(cmbo);
                    NavigationService.Navigate(new CustomizeCombo(cmbo));
                    break;
                case "6":
                    NavigationService.Navigate(new CustomizeVelociwrap(new CretaceousCombo(new VelociWrap())));
                    break;
            }
        }
    }
}
