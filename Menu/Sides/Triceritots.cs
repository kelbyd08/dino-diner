using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Triceritots : Side
    {
        public Triceritots()
        {
            name = "Triceritots";
            calories = new List<uint>() { 352, 410, 590 };
            ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
        /// <summary>
        /// Special Instructions for side creation
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
