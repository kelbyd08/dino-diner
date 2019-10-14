using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace DinoDiner.Menu
{
    class Menu
    {
        List<Entree> entrees = new List<Entree>() { new Brontowurst(),
                                                    new DinoNuggets(),
                                                    new PrehistoricPBJ(),
                                                    new PterodactylWings(),
                                                    new SteakosaurusBurger(),
                                                    new TRexKingBurger(),
                                                    new VelociWrap() };
        List<Drink> drinks = new List<Drink>(){ new JurassicJava(),
                                                new Sodasaurus(),
                                                new Tyrannotea(),
                                                new Water()
                                                };
        List<Side> sides = new List<Side>() {   new Fryceritops(),
                                                new MeteorMacAndCheese(),
                                                new MezzorellaSticks(),
                                                new Triceritots() };
            
        public Menu()
        {
            
        }
    }
}
