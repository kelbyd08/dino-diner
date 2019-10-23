using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{

    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events for properties such as Ingredients and Special
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected double[] prices = new double[3];

        /// <summary>
        /// The name of each item
        /// </summary>
        protected string name;

        /// <summary>
        /// An extra string to be appended to the name
        /// </summary>
        protected string extra = "";

        /// <summary>
        /// The amount of calories in each size
        /// </summary>
        protected uint[] calories;

        /// <summary>
        /// The total calories within the item. This is not representative of the calories 
        /// after removing ingrients.
        /// </summary>
        public virtual uint Calories
        {
            get { return ( calories[ ( int )Size ] ); }
        }

        protected bool ice = true;

        public bool Ice { get { return ice; } }

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
        /// The price of the current entree. Includes the additional items.
        /// </summary>
        public virtual double Price
        {
            get { return prices[ (int)Size ]; }
        }

        Size size = Size.Small;
        /// <summary>
        /// Current size of the item.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");

            }
        }

        /// <summary>
        /// Removes Ice from the drink 
        /// </summary>
        public void HoldIce()
        {
            ice = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Overridden ToString()
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Size + extra + " " + name;
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
        public abstract string[] Special
        {
            get;
        }
    }
}
