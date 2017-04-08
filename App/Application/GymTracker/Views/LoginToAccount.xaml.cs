using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
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
using Extensions.Debug;
using System.Linq;
using GymTracker.Classes;

namespace GymTracker.Views
{
    /// <summary>
    /// Interaction logic for LoginToAccount.xaml
    /// </summary>
    public partial class LoginToAccount : Page
    {
        private Login ParentWin;

        public LoginToAccount(Login parent)
        {
            InitializeComponent();
            ParentWin = parent;
            LoginButton.IsEnabled = false;
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            var query = from user in AppState.Userlist
                where user.Username == UsernameBox.Text && user.Password == PasswordBox.Password
                select user;

            var i = 0;
            foreach (var user in query)
            {
                i++;
            }

            if (i > 0)
            {
                //Login fuction

                MessageBox.Show("Login Accepted");
            }
            else
            {
                PasswordBox.Clear();
                UsernameBox.Clear();
                MessageBox.Show("Username or Password Incorrect", "Login Error", MessageBoxButton.OK);
            }
        }

        private void CreateAccount_OnClick(object sender, RoutedEventArgs e)
        {
            ParentWin.LoginFrame.Content = ParentWin.CreateInstnc;
            
        }

        private void ResetPassword_OnClick(object sender, RoutedEventArgs e)
        {
            ParentWin.LoginFrame.Content = ParentWin.ResPasInstnc;
        }

        private bool UNEntered = false;
        private bool PassEntered = false;

        private void UsernameBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(UsernameBox.Text))
            {
                UNEntered = true;
                if (PassEntered == true)
                {
                    LoginButton.IsEnabled = true;
                }
            }
            else
            {
                LoginButton.IsEnabled = false;
            }
            
           
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                PassEntered = true;
                if (UNEntered == true)
                {
                    LoginButton.IsEnabled = true;
                }
            }
            else
            {
                LoginButton.IsEnabled = false;
            }
        }
    }
}
