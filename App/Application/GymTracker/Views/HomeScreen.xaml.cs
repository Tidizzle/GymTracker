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

namespace GymTracker.Views
{
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Page
    {
        public HomeScreen()
        {
            InitializeComponent();
            extended = true;
            locked = false;
            MenuBar.Width = minWidth;
        }

        private bool extended;
        private bool locked;
        private GridLength maxWidth = new GridLength(266);
        private GridLength minWidth = new GridLength(100);

        private void LockMenuButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (locked)
            {
                locked = false;
            }
            else
            {
                locked = true;
            }

        }


        private void Menu_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (!locked)
            {
                if (!extended)
                {
                    MenuBar.Width = maxWidth;
                    extended = true;
                }
            }
        }

        private void Menu_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (!locked)
            {
                if (extended)
                {
                    MenuBar.Width = minWidth;
                    extended = false;
                }
            }
        }
    }
}
