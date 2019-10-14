using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem
    {
        List<string> Ingredients
        {
            get;
        }
        uint Calories
        {
            get;
        }
        double Price
        {
            get;
        }
    }
}
