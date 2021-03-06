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
using GymTracker.Classes;

namespace GymTracker.Views.SubViews
{
    /// <summary>
    /// Interaction logic for ResetSecurityQues.xaml
    /// </summary>
    public partial class ResetSecurityQues : Page
    {
        private ResetPassword ParentWin;
        public Label SecQuesLbl;
        public TextBox SecAnsBox;
        internal User ResettingUser;

        public ResetSecurityQues(ResetPassword parent, User foundUser)
        {
            InitializeComponent();
            ParentWin = parent;

            SecQuesLbl = SecQues;
            SecAnsBox = AnswerTextBox;

            SecQues.Content = foundUser.SecurityQues;
            ResettingUser = foundUser;
        }

        private void AnswerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(AnswerTextBox.Text))
                ParentWin.FrameButton.IsEnabled = true;
            else
                ParentWin.FrameButton.IsEnabled = false;
        }
    }
}
