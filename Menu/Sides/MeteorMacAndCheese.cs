using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side
    {
        public MeteorMacAndCheese()
        {
            name = "Meteor Mac and Cheese";
            calories = new List<uint>() { 420, 490, 520 };
            ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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
