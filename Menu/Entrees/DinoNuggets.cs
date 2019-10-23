using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Creates a DinoNugget object. Price: $4.25, Calories per Nugget: 59, Count: 6
        /// </summary>
        public DinoNuggets()
        {
            name = "Dino-Nuggets";
            ingredients = new List<string>() { "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget", "Chicken Nugget" };
            price = 4.25;
            calories = 59;
            count = 6;
            add_price = 0.25;
            base_count = count;
        }

        /// <summary>
        /// Adds a new nugget.
        /// </summary>
        public void AddNugget()
        {
            ingredients.Add( "Chicken Nugget" );
            count += 1;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Price");

        }
        /// <summary>
        /// Special instructions for entree creation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(count - base_count + " Extra Nuggets");
                return special.ToArray();
            }
        }
    }
}
