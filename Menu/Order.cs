/*  Order.cs
*   Author: Kelby Dinkel
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// Constructor for the order
        /// </summary>
        /// <param name="TaxRate">Current tax rate</param>
        public Order( double TaxRate)
        {
            SalesTaxRate = TaxRate;
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
            get { return Items.Sum(item => item.Price); }
        }
        double taxRate;
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
