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
using Extensions.Debug;

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
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void CreateAccount_OnClick(object sender, RoutedEventArgs e)
        {
            ParentWin.LoginFrame.Content = ParentWin.CreateInstnc;
            
        }

        private void ResetPassword_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
