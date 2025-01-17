﻿using System;
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
    public enum PreviousPage
    {
        Entree,
        Combo
    };
    /// <summary>
    /// Interaction logic for CustomisePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomisePrehistoricPBJ : Page
    {
        private PreviousPage page;
        private PrehistoricPBJ pbj;
        private CretaceousCombo cmbo;
        public CustomisePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            this.page = page;
            this.pbj = pbj;
            InitializeComponent();
        }

        public CustomisePrehistoricPBJ( CretaceousCombo cmbo )
        {
            InitializeComponent();
            this.cmbo = cmbo;
            ((Order)App.Current.MainWindow.DataContext).Items.Add(cmbo);
        }
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            if (cmbo != null)
                (cmbo.Entree as PrehistoricPBJ).HoldPeanutButter();
            else
                pbj.HoldPeanutButter();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            if (cmbo != null)
                (cmbo.Entree as PrehistoricPBJ).HoldJelly();
            else
                pbj.HoldJelly();
        }
        private void OnDone(object secnder, RoutedEventArgs args)
        {
            if( cmbo != null)
                NavigationService.Navigate(new CustomizeCombo(cmbo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
