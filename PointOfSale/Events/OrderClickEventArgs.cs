using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DinoDiner.Menu;

namespace PointOfSale.Events
{
    public class OrderClickEventArgs : RoutedEventArgs
    {
        public IOrderItem SelectedItem { get; protected set; }
        public int Index { get; protected set; }
        public OrderClickEventArgs(RoutedEvent routedEvent, IOrderItem item, int index) : base(routedEvent)
        {
            SelectedItem = item;
            Index = index;
        }
    }
}
