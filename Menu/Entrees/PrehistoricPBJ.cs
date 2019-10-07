using System.Collections.Generic;


namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
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
        }
        
        /// <summary>
        /// Removes the jelly from the sandwich.
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
        }
    }
}
