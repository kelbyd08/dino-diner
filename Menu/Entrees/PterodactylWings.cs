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
        
    }
}
