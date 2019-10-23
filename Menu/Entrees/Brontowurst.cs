using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Creates a new Brontowurst. Has a price of $5.36, calories of 498 and count of 1.
        /// </summary>
        public Brontowurst()
        {
            name = "Brontowurst";
            ingredients = new List<string>() { "Brautwurst", "Whole Wheat Bun", "Peppers", "Onion" };
            price = 5.36;
            calories = 498;
            count = 1;
        }

        /// <summary>
        /// Removes the bun from the ingredients.
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove( "Whole Wheat Bun" );
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the peppers from the ingredients.
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove( "Peppers" );
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the onion from the ingrients.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove( "Onion" );
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
                if (!ingredients.Contains("Peppers")) special.Add("Hold Peppers");
                if (!ingredients.Contains("Onion")) special.Add("Hold Onion");
                return special.ToArray();
            }
        }
    }
}
