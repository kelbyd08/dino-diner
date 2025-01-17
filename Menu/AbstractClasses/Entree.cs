﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events for properties such as Ingredients and Special
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// The name of each item
        /// </summary>
        protected string name;
        /// <summary>
        /// The price for each additional item.
        /// </summary>
        protected double add_price = 0.00;

        /// <summary>
        /// The base price
        /// </summary>
        protected double price;

        /// <summary>
        /// The price of the current entree. Includes the additional items.
        /// </summary>
        public double Price
        {
            get { return price + ( count - base_count ) * add_price; }
        }

        /// <summary>
        /// Current count of the items. This should be the updated count.
        /// </summary>
        protected uint count = 1;

        /// <summary>
        /// The default count of the items. Used when calculating the price.
        /// It should be set to the base count when additional items can be added.
        /// </summary>
        protected uint base_count = 1;

        /// <summary>
        /// The amount of calories in one. For example, with nuggets, it should be the 
        /// calories for one nugget.
        /// </summary>
        protected uint calories;

        /// <summary>
        /// The total calories within the item. This is not representative of the calories 
        /// after removing ingrients. It is updated to show additional items.
        /// </summary>
        public uint Calories
        {
            get { return (calories * count); }
        }

        /// <summary>
        /// List of ingriendents.
        /// </summary>
        protected List<string> ingredients;

        /// <summary>
        /// Returns a copy of the ingredients list.
        /// </summary>
        public List<string> Ingredients
        {
            get { return new List<string>(ingredients); }
        }
        /// <summary>
        /// Overridden ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return name;
        }
        /// <summary>
        /// The description of the current menu item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Special instructions for the entree
        /// </summary>
        public abstract string[] Special {
            get;
        }
    }
}
