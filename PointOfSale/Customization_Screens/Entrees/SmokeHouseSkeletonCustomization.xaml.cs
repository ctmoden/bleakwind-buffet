﻿using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Customization_Screens
{
    /// <summary>
    /// Interaction logic for SmokeHouseSkeletonCustomization.xaml
    /// </summary>
    public partial class SmokeHouseSkeletonCustomization : UserControl
    {
        SmokehouseSkeleton skeleton;
        MenuSelection menu;
        /// <summary>
        /// Custom screen
        /// </summary>
        /// <param name="s"></param>
        public SmokeHouseSkeletonCustomization(MenuSelection m, SmokehouseSkeleton s)
        {
            InitializeComponent();
            skeleton = s;
            menu = m;
            DataContext = skeleton;
        }
        /// <summary>
        /// Returns to main menu screen to continue order process
        /// </summary>
        /// <param name="sender">object that sent event we are handling</param>
        /// <param name="e">parameters of event</param>
        void ReturnToMainMenu(object sender, RoutedEventArgs e)
        {
            ReturnToMenu.ReturnToMenuScreen(this, menu);
        }
    }
}
