﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.AbstractClasses;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        public VelociWrap()
        {
            ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Romaine Lettuce", "Ceasar Dressing", "Parmesan Cheese" };
            price = 6.86;
            calories = 356;
            count = 1;
        }
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
        }
        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
        }
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
        }
    }
}