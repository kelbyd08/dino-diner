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
                foreach(CretaceousCombo cmbo in menu.combos)
                {
                    if(cmbo.Description.Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbos.Add(cmbo);
                    }
                }
                menu.combos = cmbos;

                List<Entree> entrees = new List<Entree>();
                foreach (Entree entr in menu.entrees)
                {
                    if (entr.Description.Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        entrees.Add(entr);
                    }
                }
                menu.entrees = entrees;
                List<Drink> drinks = new List<Drink>();
                foreach (Drink dnk in menu.drinks)
                {
                    if (dnk.Description.Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        drinks.Add(dnk);
                    }
                }
                menu.drinks = drinks;
                List<Side> sides = new List<Side>();
                foreach (Side sd in menu.sides)
                {
                    if (sd.Description.Contains(search, StringComparison.OrdinalIgnoreCase))
                    {
                        sides.Add(sd);
                    }
                }
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
                foreach (CretaceousCombo cmbo in menu.combos)
                {
                    if (cmbo.Price > minimumPrice)
                    {
                        cmbos.Add(cmbo);
                    }
                }
                menu.combos = cmbos;

                List<Entree> entrees = new List<Entree>();
                foreach (Entree entr in menu.entrees)
                {
                    if (entr.Price > minimumPrice)
                    {
                        entrees.Add(entr);
                    }
                }
                menu.entrees = entrees;
                List<Drink> drinks = new List<Drink>();
                foreach (Drink dnk in menu.drinks)
                {
                    if (dnk.Price > minimumPrice)
                    {
                        drinks.Add(dnk);
                    }
                }
                menu.drinks = drinks;
                List<Side> sides = new List<Side>();
                foreach (Side sd in menu.sides)
                {
                    if (sd.Price > minimumPrice)
                    {
                        sides.Add(sd);
                    }
                }
                menu.sides = sides;
            }

            if (maximumPrice != null)
            {
                List<CretaceousCombo> cmbos = new List<CretaceousCombo>();
                foreach (CretaceousCombo cmbo in menu.combos)
                {
                    if (cmbo.Price < maximumPrice)
                    {
                        cmbos.Add(cmbo);
                    }
                }
                menu.combos = cmbos;

                List<Entree> entrees = new List<Entree>();
                foreach (Entree entr in menu.entrees)
                {
                    if (entr.Price < maximumPrice)
                    {
                        entrees.Add(entr);
                    }
                }
                menu.entrees = entrees;
                List<Drink> drinks = new List<Drink>();
                foreach (Drink dnk in menu.drinks)
                {
                    if (dnk.Price < maximumPrice)
                    {
                        drinks.Add(dnk);
                    }
                }
                menu.drinks = drinks;
                List<Side> sides = new List<Side>();
                foreach (Side sd in menu.sides)
                {
                    if (sd.Price < maximumPrice)
                    {
                        sides.Add(sd);
                    }
                }
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

                foreach (string ing in filteredIngredients)
                {
                    foreach (CretaceousCombo cmbo in menu.combos)
                    {
                        if (!cmbo.Ingredients.Contains(ing))
                        {
                            cmbos.Add(cmbo);
                        }
                    }

                    foreach (Entree entr in menu.entrees)
                    {
                        if (!entr.Ingredients.Contains(ing))
                        {
                            entrees.Add(entr);
                        }
                    }
                    foreach (Drink dnk in menu.drinks)
                    {
                        if (!dnk.Ingredients.Contains(ing))
                        {
                            drinks.Add(dnk);
                        }
                    }
                    foreach (Side sd in menu.sides)
                    {
                        if (!sd.Ingredients.Contains(ing))
                        {
                            sides.Add(sd);
                        }
                    }
                }
                menu.combos = cmbos;
                menu.entrees = entrees;
                menu.drinks = drinks;
                menu.sides = sides;

            }
            #endregion
        }
    }
}