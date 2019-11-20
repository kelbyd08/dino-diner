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
using DinoDiner.Menu;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {

        readonly string[] img_srcs = new string[]
        {
            "Images/DinoDiner-14.png",
            "Images/DinoDiner-12.png",
            "Images/DinoDiner-13.png",
            "Images/DinoDiner-15.png"
        };
        bool edit = false;
        int index;
        private CretaceousCombo cmbo;
        public DrinkSelection(Drink drink = null, bool edit = false, int index = 0)
        {
            DataContext = drink;
            this.edit = edit;
            this.index = index;

            InitializeComponent();
            if (drink != null)
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();

                if (drink is Tyrannotea)
                {
                    show_tea();
                    img.UriSource = new Uri("pack://application:,,,/" + img_srcs[1]);
                }
                else if (drink is Sodasaurus)
                {
                    img.UriSource = new Uri("pack://application:,,,/" + img_srcs[0]);
                    show_soda();
                }
                else if (drink is Water)
                {
                    show_water();
                    img.UriSource = new Uri("pack://application:,,,/" + img_srcs[3]);
                }
                else if (drink is JurassicJava)
                {
                    show_java();
                    img.UriSource = new Uri("pack://application:,,,/" + img_srcs[2]);
                }
                img.EndInit();
                SelectedDrink.Source = img;
            }
        }

        public DrinkSelection( CretaceousCombo cmbo )
        {
            InitializeComponent();
            this.cmbo = cmbo;
            DataContext = cmbo.Drink;
            if (cmbo.Drink != null)
            {
                BitmapImage img = new BitmapImage();
                img.BeginInit();

                if (cmbo.Drink is Tyrannotea)
                {
                    show_tea();
                    img.UriSource = new Uri("pack://application:,,,/" + img_srcs[1]);
                }
                else if (cmbo.Drink is Sodasaurus)
                {
                    img.UriSource = new Uri("pack://application:,,,/" + img_srcs[0]);
                    show_soda();
                }
                else if (cmbo.Drink is Water)
                {
                    show_water();
                    img.UriSource = new Uri("pack://application:,,,/" + img_srcs[3]);
                }
                else if (cmbo.Drink is JurassicJava)
                {
                    show_java();
                    img.UriSource = new Uri("pack://application:,,,/" + img_srcs[2]);
                }
                img.EndInit();
                SelectedDrink.Source = img;
            }
        }

        private void show_soda()
        {
            //Delete all objects from the additional options panel

            AdditionalOptions.Children.Clear();

            //Create a new flavor button and assign the click handler
            Button btn = new Button();
            btn.Content = "Flavor";
            btn.Click += FlavorClick;
            AdditionalOptions.Children.Add(btn);

        }
        private void show_java()
        {
            AdditionalOptions.Children.Clear();
            Button btn = new Button();
            btn.Content = "Decaf";
            AdditionalOptions.Children.Add(btn);
            btn = new Button();
            btn.Content = "Add Ice";
            AdditionalOptions.Children.Add(btn);
        }
        private void show_tea()
        {
            AdditionalOptions.Children.Clear();
            Button btn = new Button();
            btn.Content = "Lemon";
            AdditionalOptions.Children.Add(btn);
            btn = new Button();
            btn.Content = "Sweet";
            AdditionalOptions.Children.Add(btn);
        }

        private void show_water()
        {
            AdditionalOptions.Children.Clear();
            Button btn = new Button();
            btn.VerticalAlignment = VerticalAlignment.Bottom;
            btn.Content = "Lemon";
            AdditionalOptions.Children.Add(btn);
        }
        /// <summary>
        /// Click handler for the soda button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void SodaClick(object sender, RoutedEventArgs e)
        {
            show_soda();
            DataContext = new Sodasaurus();
            /*----------------------------------------------------------------
            Set the currently selected drink image
            ----------------------------------------------------------------*/
            BitmapImage drink = new BitmapImage();
            drink.BeginInit();
            drink.UriSource = new Uri("pack://application:,,,/" + img_srcs[0]);
            drink.EndInit();
            SelectedDrink.Source = drink;
        }
        /// <summary>
        /// Click handler for the tea button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void TeaClick(object sender, RoutedEventArgs e)
        {
            show_tea();

            DataContext = new Tyrannotea();
            if (cmbo != null)
                cmbo.Drink = DataContext as Tyrannotea;
            /*----------------------------------------------------------------
            Set the currently selected drink image
            ----------------------------------------------------------------*/
            BitmapImage drink = new BitmapImage();
            drink.BeginInit();
            drink.UriSource = new Uri("pack://application:,,,/" + img_srcs[1]);
            drink.EndInit();
            SelectedDrink.Source = drink;
        }
        /// <summary>
        /// Click handler for the coffee button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void CoffeeClick(object sender, RoutedEventArgs e)
        {
            show_java();

            DataContext = new JurassicJava();
            /*----------------------------------------------------------------
            Set the currently selected drink image
            ----------------------------------------------------------------*/
            BitmapImage drink = new BitmapImage();
            drink.BeginInit();
            drink.UriSource = new Uri("pack://application:,,,/" + img_srcs[2]);
            drink.EndInit();
            SelectedDrink.Source = drink;
        }
        /// <summary>
        /// Click handler for the water button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void WaterClick(object sender, RoutedEventArgs e)
        {
            show_water();

            DataContext = new Water();

            /*----------------------------------------------------------------
            Set the currently selected drink image
            ----------------------------------------------------------------*/
            BitmapImage drink = new BitmapImage();
            drink.BeginInit();
            drink.UriSource = new Uri("pack://application:,,,/" + img_srcs[3]);
            drink.EndInit();
            SelectedDrink.Source = drink;
        }
        /// <summary>
        /// Click handler for the flavor button
        /// </summary>
        /// <param name="sender">The object that sent the event</param>
        /// <param name="e">The arguements of the event</param>
        private void FlavorClick(object sender, RoutedEventArgs e)
        {
            FlavorSelection flvr;
            if (cmbo != null)
            {
                flvr = new FlavorSelection(cmbo);
            }
            else
            {
                flvr = new FlavorSelection(edit, index);
            }
            flvr.DataContext = DataContext;
            NavigationService.Navigate(flvr);
        }

        private void SizeChecked(object sender, RoutedEventArgs args)
        {
            Button btn = sender as Button;
            if (DataContext != null)
            {
                if (DataContext is Sodasaurus soda)
                    DataContext = DataContext;
                switch (btn.Content.ToString())
                {
                    case "Small":
                        ((Drink)DataContext).Size = DinoDiner.Menu.Size.Small;
                        break;

                    case "Medium":
                        ((Drink)DataContext).Size = DinoDiner.Menu.Size.Medium;
                        break;

                    case "Large":
                        ((Drink)DataContext).Size = DinoDiner.Menu.Size.Large;
                        break;
                }
                if ( cmbo != null )
                {
                    cmbo.Drink = (Drink)DataContext;
                }
                else if (!edit)
                {
                    ((Order)App.Current.MainWindow.DataContext).Items.Add((Drink)DataContext);
                }
                else
                {
                    ((Order)App.Current.MainWindow.DataContext).Items[index] = (Drink)DataContext;
                }
                if (cmbo == null)
                    NavigationService.Navigate(new MenuCategorySelection());
                else
                    NavigationService.Navigate(new CustomizeCombo(cmbo));
            }
        }
    }
}
