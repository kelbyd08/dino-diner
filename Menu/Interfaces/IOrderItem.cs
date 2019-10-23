/*  IOrderItem.cs
*   Author: Kelby Dinkel
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the order item
        /// </summary>
        double Price
        {
            get;
        }
        /// <summary>
        /// The description of the order item
        /// </summary>
        string Description
        {
            get;
        }
        /// <summary>
        /// Any special instructions for the order item
        /// </summary>
        string[] Special
        {
            get;
        }
    }
}
