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

namespace GymTracker.Views.SubViews
{
    /// <summary>
    /// Interaction logic for ResetFindAcct.xaml
    /// </summary>
    public partial class ResetFindAcct : Page
    {
        private ResetPassword ParentWin;
        public TextBox UsernameTextbox;

        public ResetFindAcct(ResetPassword Parent)
        {
            InitializeComponent();
            ParentWin = Parent;
            UsernameTextbox = FindUNTextbox;
            ParentWin.FrameButton.IsEnabled = false;
        }


        private void FindUNTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FindUNTextbox.Text))
            {
                ParentWin.FrameButton.IsEnabled = true;
            }
            else
            {
                ParentWin.FrameButton.IsEnabled = false;
            }
        }
    }
}
