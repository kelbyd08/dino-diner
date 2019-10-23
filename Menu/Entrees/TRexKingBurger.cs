using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Creates a new TRexKingBurger Instance. 
        /// </summary>
        public TRexKingBurger()
        {
            name = "T-Rex King Burger";
            ingredients = new List<string>() { "Whole Wheat Bun", "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie", "Lettuce", "Tomato", "Onion", "Pickle", "Ketchup", "Mustard", "Mayo" };
            price = 8.45;
            calories = 728;
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
        /// Removes the lettuce from the burger.
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the tomato from the burger.
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the onion from the burger.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the pickle from the burger.
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the ketchup from the burger.
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
        /// Removes the mayo from the burger
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
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
                if (!ingredients.Contains("Lettuce")) special.Add("Hold Lettuce");
                if (!ingredients.Contains("Tomato")) special.Add("Hold Tomato");
                if (!ingredients.Contains("Onion")) special.Add("Hold Onion");
                if (!ingredients.Contains("Pickle")) special.Add("Hold Pickle");
                if (!ingredients.Contains("Ketchup")) special.Add("Hold Ketchup");
                if (!ingredients.Contains("Mustard")) special.Add("Hold Mustard");
                if (!ingredients.Contains("Mayo")) special.Add("Hold Mayo");

                return special.ToArray();
            }
        }
    }
}
