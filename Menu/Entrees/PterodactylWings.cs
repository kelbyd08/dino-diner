using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Creates a new PterodactylWings instance.
        /// </summary>
        public PterodactylWings()
        {
            name = "Pterodactyl Wings";
            ingredients = new List<string>() { "Chicken", "Wing Sauce" };
            price = 7.21;
            calories = 318;
            count = 1;
        }
        /// <summary>
        /// Special Instructions for entree creation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
