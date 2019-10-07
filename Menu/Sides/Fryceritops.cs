using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side
    {
        public Fryceritops()
        {
            name = "Fryceritops";
            calories = new List<uint>() { 222, 365, 480 };
            ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
