using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<CretaceousCombo> combos = new List<CretaceousCombo>() 
                                                                { 
                                                                new CretaceousCombo(new Brontowurst()),
                                                                new CretaceousCombo(new DinoNuggets()),
                                                                new CretaceousCombo(new PrehistoricPBJ()),
                                                                new CretaceousCombo(new PterodactylWings()),
                                                                new CretaceousCombo(new SteakosaurusBurger()),
                                                                new CretaceousCombo(new TRexKingBurger()),
                                                                new CretaceousCombo(new VelociWrap()),
                                                                };
        public List<Entree> entrees = new List<Entree>() { new Brontowurst(),
                                                    new DinoNuggets(),
                                                    new PrehistoricPBJ(),
                                                    new PterodactylWings(),
                                                    new SteakosaurusBurger(),
                                                    new TRexKingBurger(),
                                                    new VelociWrap() };
        public List<Drink> drinks = new List<Drink>(){ new JurassicJava(),
                                                new Sodasaurus(),
                                                new Tyrannotea(),
                                                new Water()
                                                };
        public List<Side> sides = new List<Side>() {   new Fryceritops(),
                                                new MeteorMacAndCheese(),
                                                new MezzorellaSticks(),
                                                new Triceritots() };

        public HashSet<string> PossibleIngredients = new HashSet<string>();
        public Menu()
        {
            foreach(CretaceousCombo cmbo in combos)
            {
                PossibleIngredients.UnionWith(cmbo.Ingredients);
            }
            foreach (Drink drink in drinks)
            {
                PossibleIngredients.UnionWith(drink.Ingredients);
            }
            foreach (Side side in sides)
            {
                PossibleIngredients.UnionWith(side.Ingredients);
            }
        }
    }
}
