using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IMenuItem : INotifyPropertyChanged
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
