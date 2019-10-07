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
        }

        /// <summary>
        /// Removes the peppers from the ingredients.
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove( "Peppers" );
        }

        /// <summary>
        /// Removes the onion from the ingrients.
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove( "Onion" );
        }
    }
}
