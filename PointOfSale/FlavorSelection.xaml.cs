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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        bool editing;
        int index;
        public FlavorSelection(bool edit = false, int index = 0)
        {
            editing = edit;
            this.index = index;
            InitializeComponent();
        }
        private void OnFlavorChange( object sender, RoutedEventArgs args)
        {
            if( sender is RadioButton btn)
            {
                ((Sodasaurus)DataContext).flavor = (DinoDiner.Menu.SodasaurusFlavor)Enum.Parse(typeof(DinoDiner.Menu.SodasaurusFlavor), btn.Content.ToString().Replace(" ", "") );
                NavigationService.Navigate(new DrinkSelection((Drink)DataContext, editing, index));

            }
        }
    }
}
