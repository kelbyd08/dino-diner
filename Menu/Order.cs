/*  Order.cs
*   Author: Kelby Dinkel
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Collections.Specialized;

namespace DinoDiner.Menu
{
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for the order
        /// </summary>
        /// <param name="TaxRate">Current tax rate</param>
        public Order( double TaxRate)
        {
            SalesTaxRate = TaxRate;
            Items.CollectionChanged += CollectionChangedHandler;
        }
        /// <summary>
        /// Items within the current order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get;
            set;
        } = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// Cost before tax
        /// </summary>
        public double SubtotalCost
        {
            get {
               
                return Items.Sum(item => item.Price) > 0 ? Items.Sum(item => item.Price) : 0;  }
        }
        double taxRate;

        void CollectionChangedHandler(object sender, NotifyCollectionChangedEventArgs args)
        {
            if( args.Action == NotifyCollectionChangedAction.Add)
            {
                if( args.NewItems[ 0 ] is Entree entree)
                {
                    entree.PropertyChanged += listItemPriceChanged;
                }
                else if (args.NewItems[0] is Drink drink)
                {
                    drink.PropertyChanged += listItemPriceChanged;
                }
                else if (args.NewItems[0] is Side side)
                {
                    side.PropertyChanged += listItemPriceChanged;
                }
                else if (args.NewItems[0] is CretaceousCombo combo)
                {
                    combo.PropertyChanged += listItemPriceChanged;
                }
                else if( args.NewItems[0] is IOrderItem item )
                {
                    item.PropertyChanged += listItemPriceChanged;
                }
            }
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        void listItemPriceChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Price")
                NotifyOfPropertyChanged("SubtotalCost");
            else if (args.PropertyName == "SubtotalCost" ||
                     args.PropertyName == "TotalCost"   ||
                     args.PropertyName == "SalesTaxCost")
            {
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("TotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Current tax Rate
        /// </summary>
        public double SalesTaxRate
        {
            get { return taxRate; }
            protected set { taxRate = value;  }
        }
        /// <summary>
        /// Cost of TAx
        /// </summary>
        public double SalesTaxCost
        {
            get { return SalesTaxRate * SubtotalCost; }
        }
        /// <summary>
        /// Total cost of order
        /// </summary>
        public double TotalCost
        {
            get { return SubtotalCost > 0 ? SalesTaxCost + SubtotalCost : 0; }
        }
    }
}
