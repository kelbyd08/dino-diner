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
                NotifyOfPropertyChanged("Name");
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
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Adds ice into the drink 
        /// </summary>
        public void AddIce()
        {
            ice = true;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Special Instructions for drink creation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (ice) special.Add("Add Ice");
                if (spaceForCream) special.Add("Leave Room For Cream");
                return special.ToArray();
            }
        }
    }
}
