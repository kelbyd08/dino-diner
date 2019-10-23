using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Creates a new VelociWrap Instance.
        /// </summary>
        public VelociWrap()
        {
            name = "Veloci-Wrap";
            ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Romaine Lettuce", "Ceasar Dressing", "Parmesan Cheese" };
            price = 6.86;
            calories = 356;
            count = 1;
        }

        /// <summary>
        /// Removes the dressing 
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the Lettuce 
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the Cheese 
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
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
                if (!ingredients.Contains("Ceasar Dressing")) special.Add("Hold Dressing");
                if (!ingredients.Contains("Romaine Lettuce")) special.Add("Hold Lettuce");
                if (!ingredients.Contains("Parmesan Cheese")) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
    }
}
