/*  MenuCategorySelection.xaml.cs
*   Author: Kelby Dinkel
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click handler for the combo selection button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>  
        void SelectCombo( object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        /// <summary>
        /// Click handler for the drink selection button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Click handler for the entree selection button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// Click handler for the side selection button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }

    }
}
