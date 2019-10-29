/*  CretaceousCombo.cs
*   Author: Kelby Dinkel
*/
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.Linq;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged
    {
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            drink = new Sodasaurus();
        }
        private Entree entree;
        public Entree Entree {
            get { return entree; }
            set{
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
            }
        }
        Side side;
        public Side Side
        {
            get { return side; }
            set {
                this.side = value;
                this.side.Size = this.size;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Calories");
            }
        }
        Drink drink;
        public Drink Drink
        {
            get { return drink; }
            set {
                drink = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Drink");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Special");
            }
        }

        public double Price
        {
            get
            {
                return (Entree.Price + Side.Price + Drink.Price) - .25;
            }
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        public Size size = Size.Small;

        /// <summary>
        /// Event handler for property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = (Size)value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Calories");
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }

        public String[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
    }
}
