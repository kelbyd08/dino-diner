/*  DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click handler for the soda button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void SodaClick(object sender, RoutedEventArgs e)
        {
            //Delete all objects from the additional options panel
            StackPanel extra = ((Grid)((WrapPanel)((Button)sender).Parent).Parent).FindName("AdditionalOptions") as StackPanel;
            extra.Children.Clear();

            //Create a new flavor button and assign the click handler
            Button btn = new Button();
            btn.Content = "Flavor";
            btn.Click += FlavorClick;
            extra.Children.Add(btn);
        }
        /// <summary>
        /// Click handler for the tea button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void TeaClick(object sender, RoutedEventArgs e)
        {
            StackPanel extra = ((Grid)((WrapPanel)((Button)sender).Parent).Parent).FindName("AdditionalOptions") as StackPanel;
            extra.Children.Clear();
            Button btn = new Button();
            btn.Content = "Lemon";
            extra.Children.Add(btn);
            btn = new Button();
            btn.Content = "Sweet";
            extra.Children.Add(btn);
        }
        /// <summary>
        /// Click handler for the coffee button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void CoffeeClick(object sender, RoutedEventArgs e)
        {
            StackPanel extra = ((Grid)((WrapPanel)((Button)sender).Parent).Parent).FindName("AdditionalOptions") as StackPanel;
            extra.Children.Clear();
            Button btn = new Button();
            btn.Content = "Decaf";
            extra.Children.Add(btn);
        }
        /// <summary>
        /// Click handler for the water button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void WaterClick(object sender, RoutedEventArgs e)
        {
            StackPanel extra = ((Grid)((WrapPanel)((Button)sender).Parent).Parent).FindName("AdditionalOptions") as StackPanel;
            extra.Children.Clear();
            Button btn = new Button();
            btn.Content = "Lemon";
            extra.Children.Add(btn);
        }
        /// <summary>
        /// Click handler for the flavor button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void FlavorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
