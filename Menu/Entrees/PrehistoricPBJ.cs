using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Creates a new PrehistoricPBJ instance.
        /// </summary>
        public PrehistoricPBJ()
        {
            name = "Prehistoric PB&J";
            ingredients = new List<string>() { "Bread", "Peanut Butter", "Jelly" };
            price = 6.52;
            calories = 483;
            count = 1;
        }

        /// <summary>
        /// Removes the peanut butter from the sandwich.
        /// </summary>
        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        
        /// <summary>
        /// Removes the jelly from the sandwich.
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Special Instructions for entree creation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if ( !ingredients.Contains( "Peanut Butter" ) ) special.Add("Hold Peanut Butter");
                if ( !ingredients.Contains("Jelly")) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
