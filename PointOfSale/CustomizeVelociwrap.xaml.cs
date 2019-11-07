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
    public partial class CustomizeVelociwrap : Page
    {
        private PreviousPage page;
        private VelociWrap vw;
        private CretaceousCombo cmbo;
        public CustomizeVelociwrap(VelociWrap vw)
        {
            this.page = page;
            this.vw = vw;
            InitializeComponent();
        }

        public CustomizeVelociwrap( CretaceousCombo cmbo )
        {
            InitializeComponent();
            this.cmbo = cmbo;
            vw = cmbo.Entree as VelociWrap;
            ((Order)App.Current.MainWindow.DataContext).Items.Add(cmbo);
        }
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            vw.HoldDressing();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            vw.HoldLettuce();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            vw.HoldCheese();
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
