using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu menu = new Menu();
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> categories { get; set; } = new List<string>();

        [BindProperty]
        public List<string> filteredIngredients { get; set; } = new List<string>();
        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            menu = new Menu();

            #region search
            if ( search != null )
            {
                List<CretaceousCombo> cmbos = new List<CretaceousCombo>();
                cmbos.AddRange(menu.combos.Where(x => x.Description.Contains(search, StringComparison.OrdinalIgnoreCase)));
                menu.combos = cmbos;

                List<Entree> entrees = new List<Entree>();
                entrees.AddRange(menu.entrees.Where(x => x.Description.Contains(search, StringComparison.OrdinalIgnoreCase)));
                menu.entrees = entrees;
                List<Drink> drinks = new List<Drink>();
                drinks.AddRange(menu.drinks.Where(x => x.Description.Contains(search, StringComparison.OrdinalIgnoreCase)));
                menu.drinks = drinks;
                List<Side> sides = new List<Side>();
                sides.AddRange(menu.sides.Where(x => x.Description.Contains(search, StringComparison.OrdinalIgnoreCase)));
                menu.sides = sides;
            }
            #endregion

            #region category
            if( categories.Count != 0)
            {
                if(!categories.Contains("Combo"))
                {
                    menu.combos = new List<CretaceousCombo>();
                }
                if (!categories.Contains("Entree"))
                {
                    menu.entrees = new List<Entree>();
                }
                if (!categories.Contains("Drink"))
                {
                    menu.drinks = new List<Drink>();
                }
                if (!categories.Contains("Side"))
                {
                    menu.sides = new List<Side>();
                }
            }
            #endregion

            #region price
            if(minimumPrice != null )
            {
                List<CretaceousCombo> cmbos = new List<CretaceousCombo>();
                cmbos.AddRange(menu.combos.Where(x => x.Price > minimumPrice));
                menu.combos = cmbos;

                List<Entree> entrees = new List<Entree>();
                entrees.AddRange(menu.entrees.Where(x => x.Price > minimumPrice));
                menu.entrees = entrees;

                List<Drink> drinks = new List<Drink>();
                drinks.AddRange(menu.drinks.Where(x => x.Price > minimumPrice));
                menu.drinks = drinks;
                List<Side> sides = new List<Side>();
                sides.AddRange(menu.sides.Where(x => x.Price > minimumPrice));
                menu.sides = sides;
            }

            if (maximumPrice != null)
            {
                List<CretaceousCombo> cmbos = new List<CretaceousCombo>();

                cmbos.AddRange(menu.combos.Where(x => x.Price < maximumPrice));

                menu.combos = cmbos;

                List<Entree> entrees = new List<Entree>();

                entrees.AddRange(menu.entrees.Where(x => x.Price < maximumPrice));
                menu.entrees = entrees;

                List<Drink> drinks = new List<Drink>();
                drinks.AddRange(menu.drinks.Where(x => x.Price < maximumPrice));
                menu.drinks = drinks;
                List<Side> sides = new List<Side>();
                sides.AddRange(menu.sides.Where(x => x.Price < maximumPrice));
                menu.sides = sides;
            }
            #endregion

            #region ingredients
            if (filteredIngredients.Count != 0)
            {
                List<CretaceousCombo> cmbos = new List<CretaceousCombo>();
                List<Entree> entrees = new List<Entree>();
                List<Drink> drinks = new List<Drink>();
                List<Side> sides = new List<Side>();

                cmbos.AddRange(menu.combos.Where(x => !x.Ingredients.Intersect(filteredIngredients).Any()));

                entrees.AddRange(menu.entrees.Where(x => !x.Ingredients.Intersect(filteredIngredients).Any()));

                drinks.AddRange(menu.drinks.Where(x => !x.Ingredients.Intersect(filteredIngredients).Any()));
                sides.AddRange(menu.sides.Where(x => !x.Ingredients.Intersect(filteredIngredients).Any()));
                menu.combos = cmbos;
                menu.entrees = entrees;
                menu.drinks = drinks;
                menu.sides = sides;

            }
            #endregion
        }
    }
}