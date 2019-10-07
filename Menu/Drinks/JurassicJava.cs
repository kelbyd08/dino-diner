using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        public JurassicJava()
        {
            name = "Jurassic Java";
            ice = false;
            prices = new double[] { .59, .99, 1.49 };
            calories = new uint[] { 2, 4, 8 };
            ingredients = new List<string>() { "Water", "Coffee" };
        }
        bool spaceForCream = false;
        /// <summary>
        /// Returns if space should be shaved for cream
        /// </summary>
        public bool SpaceForCream { get { return spaceForCream; } }

        /// <summary>
        /// Returns if the coffee should be decaffinated
        /// </summary>
        bool decaf;

        /// <summary>
        /// Returns if the coffee should be decaffinated
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                if (value)
                    extra = " Decaf";
                else
                    extra = "";
                decaf = value;
            }
        }
        /// <summary>
        /// Keeps space for cream in the drink. 
        /// </summary>
        public void LeaveRoomForCream()
        {
            spaceForCream = true;
        }
        /// <summary>
        /// Adds ice into the drink 
        /// </summary>
        public void AddIce()
        {
            ice = true;
        }
    }
}
