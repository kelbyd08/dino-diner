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
    public enum PreviousPage
    {
        Entree,
        Combo
    };
    /// <summary>
    /// Interaction logic for CustomisePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomisePrehistoricPBJ : Page
    {
        private PreviousPage page;
        private PrehistoricPBJ pbj;
        public CustomisePrehistoricPBJ(PrehistoricPBJ pbj, PreviousPage page)
        {
            this.page = page;
            this.pbj = pbj;
            InitializeComponent();
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }
        private void OnDone(object secnder, RoutedEventArgs args)
        {
            switch(page)
            {
                case PreviousPage.Entree:
                    NavigationService.Navigate(new MenuCategorySelection());
                    break;

                case PreviousPage.Combo:
                    NavigationService.Navigate(new CustomizeCombo());
                    break;

            }
        }
    }
}
