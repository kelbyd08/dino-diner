﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        /// <summary>
        /// Creates a new water instance
        /// </summary>
        public Water()
        {
            name = "Water";

            ingredients = new List<string>() { "Water" };
            prices = new double[] { .1, .1, .1 };
            
            calories = new uint[] { 0, 0, 0 };
        }
        bool lemon = false;
        /// <summary>
        /// Returns whether Lemon should be added into the drink
        /// </summary>
        public bool Lemon { get { return lemon; } }
        /// <summary>
        /// Adds lemon into the drink 
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            ingredients.Add("Lemon");
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
                if (!ice) special.Add("Hold Ice");
                if (lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
