using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
    {
        public MezzorellaSticks()
        {
            name = "Mezzorella Sticks";
            calories = new List<uint>() { 540, 610, 720 };
            ingredients = new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };

        }
    }
}
