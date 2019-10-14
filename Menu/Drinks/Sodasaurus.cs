/*  Sodasaurus
*   Author: Kelby Dinkel
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Enum of possible soda flavors
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        Orange,
        Vanilla,
        Chocolate,
        RootBeer,
        Cherry,
        Lime
    };

    public class Sodasaurus : Drink
    {
        SodasaurusFlavor _flavor;
        public SodasaurusFlavor flavor
        {
            get { return _flavor; }
            set {
                extra = " " + value.ToString();
                _flavor = value;
            }
        }
        /// <summary>
        /// Creates a new Sodasaurus instance
        /// </summary>
        public Sodasaurus()
        {
            name = "Sodasaurus";
            ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            prices = new double[] { 1.5, 2, 2.5 };
            calories = new uint[] { 112, 156, 208 };
        }
    }
}
