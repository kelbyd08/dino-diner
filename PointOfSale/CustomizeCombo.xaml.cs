/*  CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click handler for the drink button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void DrinkClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// Click handler for the side
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void SideClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
    }
}
