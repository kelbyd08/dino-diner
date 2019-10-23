using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Creates a new SteakosaurusBurger.
        /// </summary>
        public SteakosaurusBurger()
        {
            name = "Steakosaurus Burger";
            ingredients = new List<string>() { "Whole Wheat Bun", "Steakburger Pattie", "Pickle", "Ketchup", "Mustard" };
            price = 5.15;
            calories = 621;
            count = 1;
        }

        /// <summary>
        /// Removes the bun from the burger.
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the pickle from the burger
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the ketchup from the burger
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the mustard from the burger.
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Special Instructions for entree creation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!ingredients.Contains("Whole Wheat Bun")) special.Add("Hold Bun");
                if (!ingredients.Contains("Pickle")) special.Add("Hold Pickle");
                if (!ingredients.Contains("Ketchup")) special.Add("Hold Ketchup");
                if (!ingredients.Contains("Mustard")) special.Add("Hold Mustard");

                return special.ToArray();
            }
        }
    }
}
