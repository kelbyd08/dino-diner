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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        public static readonly RoutedEvent SideEvent = EventManager.RegisterRoutedEvent(
            "SideClick", RoutingStrategy.Bubble, typeof(OrderClickEventHandler), typeof(OrderList));

        public static readonly RoutedEvent EntreeEvent = EventManager.RegisterRoutedEvent(
            "EntreeClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(OrderList));

        public static readonly RoutedEvent DrinkEvent = EventManager.RegisterRoutedEvent(
            "DrinkClick", RoutingStrategy.Bubble, typeof(OrderClickEventHandler), typeof(OrderList));

        public static readonly RoutedEvent ComboEvent = EventManager.RegisterRoutedEvent(
            "ComboClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(OrderList));

        public delegate void OrderClickEventHandler(object sender, OrderClickEventArgs e);
        public OrderList()
        {
            InitializeComponent();
        }

        public event OrderClickEventHandler SideClick
        {
            add { AddHandler(SideEvent, value); }
            remove { RemoveHandler(SideEvent, value); }
        }
        public event OrderClickEventHandler DrinkClick
        {
            add { AddHandler(SideEvent, value); }
            remove { RemoveHandler(SideEvent, value); }
        }

        void RaiseSideEvent( Side side, int index)
        {
            OrderClickEventArgs newEventArgs = new OrderClickEventArgs(OrderList.SideEvent, side, index);
            RaiseEvent(newEventArgs);
        }
        void RaiseDrinkEvent(Drink side, int index)
        {
            OrderClickEventArgs newEventArgs = new OrderClickEventArgs(OrderList.DrinkEvent, side, index);
            RaiseEvent(newEventArgs);
        }

        private void OnItemClick(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = sender as ListBox;
            if (e.AddedItems.Count != 0)
            {
                int index = list.SelectedIndex;

                if (e.AddedItems[0] is Side side)
                {
                    RaiseSideEvent(side, index);
                }
                else if( e.AddedItems[0] is Drink drink)
                {
                    RaiseDrinkEvent(drink, index);
                }
            (sender as ListBox).SelectedIndex = -1;
            }
        }
        private void RemoveItem( object sender, RoutedEventArgs args)
        {
            Order order = ((Order)App.Current.MainWindow.DataContext);
            if( sender is FrameworkElement element )
            {
                if(element.DataContext is IOrderItem item)
                {
                    order.Items.Remove(item);
                }
            }
        }
    }
}
