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
using PointOfSale.Events;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order(.08);
            DataContext = order;
        }

        private void OrderScreen_SideClick(object sender, OrderClickEventArgs e)
        {
            SideSelection sidePage = new SideSelection( e.SelectedItem as Side, true, e.Index);
            OrderWindow.Navigate(sidePage);
        }
        private void OrderScreen_DrinkClick( object sender, OrderClickEventArgs e)
        {
            DrinkSelection drinkPage = new DrinkSelection(e.SelectedItem as Drink, true, e.Index);
            OrderWindow.Navigate(drinkPage);
        }
        private void OnReturnToCategory(object sender, RoutedEventArgs args)
        {
            OrderWindow.Navigate(new MenuCategorySelection());
        }
    }
}
