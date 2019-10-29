using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{

    public enum Size
    {
        Small,
        Medium, 
        Large
    }


    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// An event handler for PropertyChanged events for properties such as Ingredients and Special
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        readonly double[] prices =
        {
            .99,
            1.45,
            1.95
        };
        /// <summary>
        /// The name of each item
        /// </summary>
        protected string name = "";

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
                NotifyOfPropertyChanged("Name");
                NotifyOfPropertyChanged("Description");
            }
        }


        /// <summary>
        /// The amount of calories in one. For example, with nuggets, it should be the 
        /// calories for one nugget.
        /// </summary>
        protected List<uint> calories;

        /// <summary>
        /// The total calories within the item. This is not representative of the calories 
        /// after removing ingrients. It is updated to show additional items.
        /// </summary>
        public uint Calories
        {
            get { return (calories[ (int)Size ] ); }
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
            return Size + " " + name;
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
