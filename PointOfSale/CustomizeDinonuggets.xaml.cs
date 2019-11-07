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
    public partial class CustomizeDinonuggets : Page
    {
        private PreviousPage page;
        private DinoNuggets nug;
        private CretaceousCombo cmbo;
        public CustomizeDinonuggets(DinoNuggets nug)
        {
            this.page = page;
            this.nug = nug;
            InitializeComponent();
        }

        public CustomizeDinonuggets( CretaceousCombo cmbo )
        {
            InitializeComponent();
            this.cmbo = cmbo;
            this.nug = cmbo.Entree as DinoNuggets;
            ((Order)App.Current.MainWindow.DataContext).Items.Add(cmbo);
        }

        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nug.AddNugget();
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
