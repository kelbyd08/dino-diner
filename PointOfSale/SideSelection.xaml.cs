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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        bool edit = false;
        int index;
        public SideSelection( Side side = null, bool edit = false, int index = 0 )
        {
            DataContext = side;
            this.edit = edit;
            this.index = index;
            InitializeComponent();
        }

        readonly string[] img_srcs = new string[]
        {
            "Images/DinoDiner-08.png",
            "Images/DinoDiner-11.png",
            "Images/DinoDiner-09.png",
            "Images/DinoDiner-10.png"
        };
        private void SizeChecked(object sender, RoutedEventArgs args)
        {
            Button btn = sender as Button;
            if (DataContext != null)
            {
                switch (btn.Content.ToString())
                {
                    case "Small":
                        ((Side)DataContext).Size = DinoDiner.Menu.Size.Small;
                        break;

                    case "Medium":
                        ((Side)DataContext).Size = DinoDiner.Menu.Size.Medium;
                        break;

                    case "Large":
                        ((Side)DataContext).Size = DinoDiner.Menu.Size.Large;
                        break;
                }
                if (!edit)
                {
                    ((Order)App.Current.MainWindow.DataContext).Items.Add((Side)DataContext);
                }
                else
                {
                    ((Order)App.Current.MainWindow.DataContext).Items[index] = (Side)DataContext;
                }
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        private void FryClick( object sender, RoutedEventArgs args )
        {
            DataContext = new Fryceritops();
            BitmapImage side = new BitmapImage();
            side.BeginInit();
            side.UriSource = new Uri("pack://application:,,,/" + img_srcs[0]);
            side.EndInit();
            Selected.Source = side;
        }
        private void MacNCheeseClick(object sender, RoutedEventArgs args)
        {
            DataContext = new MeteorMacAndCheese();
            BitmapImage side = new BitmapImage();
            side.BeginInit();
            side.UriSource = new Uri("pack://application:,,,/" + img_srcs[2]);
            side.EndInit();
            Selected.Source = side;
        }
        private void TotClick(object sender, RoutedEventArgs args)
        {
            DataContext = new Triceritots();
            BitmapImage side = new BitmapImage();
            side.BeginInit();
            side.UriSource = new Uri("pack://application:,,,/" + img_srcs[1]);
            side.EndInit();
            Selected.Source = side;
        }
        private void MezStickClick(object sender, RoutedEventArgs args)
        {
            DataContext = new MezzorellaSticks();
            BitmapImage side = new BitmapImage();
            side.BeginInit();
            side.UriSource = new Uri("pack://application:,,,/" + img_srcs[3]);
            side.EndInit();
            Selected.Source = side;
        }
    }
}
