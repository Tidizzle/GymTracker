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

namespace GymTracker.Views
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Page
    {
        private Login ParentWin;

        public CreateAccount(Login Parent)
        {
            InitializeComponent();
            ParentWin = Parent;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ParentWin.LoginFrame.Content = ParentWin.LoginInstnc;
        }


        private bool UNBoxEntered = false;
        private bool PassBoxEntered = false;
        private bool PassConfBoxEntered = false;
        private bool SecQuesBoxEntered = false;
        private bool SecAnsBoxEntered = false;


        private void UsernameBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UsernameBox.Text))
            {
                UNBoxEntered = true;
            }
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                PassBoxEntered = true;
            }
        }

        private void PasswordConfirmationBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordConfirmationBox.Password))
            {
                PassConfBoxEntered = true;
            }
        }

        private void SecurityQuestionBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SecurityQuestionBox.Text))
            {
                SecQuesBoxEntered = true;
            }
        }

        private void SecurityQuestionAnswerBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SecurityQuestionAnswerBox.Text))
            {
                SecAnsBoxEntered = true;
            }
        }
    }
}
