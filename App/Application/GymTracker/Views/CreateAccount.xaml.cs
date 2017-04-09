using System.Linq;
using System.Windows;
using System.Windows.Controls;
using GymTracker.Classes;

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
            CreateButton.IsEnabled = false;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            var query = from user in AppState.Userlist where user.Username == UsernameBox.Text select user;

            var i = 0;
            foreach (var user in query)
                i++;

            if (i == 0)
            {
                if (PasswordBox.Password == PasswordConfirmationBox.Password)
                {
                    var newUser = new User()
                    {
                        Username = UsernameBox.Text,
                        Password = PasswordBox.Password,
                        SecurityQues = SecurityQuestionBox.Text,
                        SecurityAns = SecurityQuestionAnswerBox.Text
                    };

                    AppState.AddUser(newUser);
                    AppState.LoadData();
                    MessageBox.Show("Account Created", "Account Creation", MessageBoxButton.OK);
                }
                else
                {
                    PasswordBox.Clear();
                    PasswordConfirmationBox.Clear();
                    MessageBox.Show("Passwords do not match", "Create Account Error", MessageBoxButton.OK);
                }
            }
            else
            {
                UsernameBox.Clear();
                MessageBox.Show("Username already exists!", "Create Account Error", MessageBoxButton.OK);
            }
            

            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ParentWin.LoginFrame.Content = ParentWin.LoginInstnc;
            UsernameBox.Clear();
            PasswordBox.Clear();
            PasswordConfirmationBox.Clear();
            SecurityQuestionBox.Clear();
            SecurityQuestionAnswerBox.Clear();

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
                if (UNBoxEntered && PassBoxEntered && PassConfBoxEntered && SecQuesBoxEntered && SecAnsBoxEntered)
                {
                    CreateButton.IsEnabled = true;
                }
            }
            else
            {
                CreateButton.IsEnabled = false;
            }
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                PassBoxEntered = true;
                if (UNBoxEntered && PassBoxEntered && PassConfBoxEntered && SecQuesBoxEntered && SecAnsBoxEntered)
                {
                    CreateButton.IsEnabled = true;
                }
            }
            else
            {
                CreateButton.IsEnabled = false;
            }
        }

        private void PasswordConfirmationBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordConfirmationBox.Password))
            {
                PassConfBoxEntered = true;
                if (UNBoxEntered && PassBoxEntered && PassConfBoxEntered && SecQuesBoxEntered && SecAnsBoxEntered)
                {
                    CreateButton.IsEnabled = true;
                }
            }
            else
            {
                CreateButton.IsEnabled = false;
            }
        }

        private void SecurityQuestionBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SecurityQuestionBox.Text))
            {
                SecQuesBoxEntered = true;
                if (UNBoxEntered && PassBoxEntered && PassConfBoxEntered && SecQuesBoxEntered && SecAnsBoxEntered)
                {
                    CreateButton.IsEnabled = true;
                }
            }
            else
            {
                CreateButton.IsEnabled = false;
            }
        }

        private void SecurityQuestionAnswerBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SecurityQuestionAnswerBox.Text))
            {
                SecAnsBoxEntered = true;
                if (UNBoxEntered && PassBoxEntered && PassConfBoxEntered && SecQuesBoxEntered && SecAnsBoxEntered)
                {
                    CreateButton.IsEnabled = true;
                }
            }
            else
            {
                CreateButton.IsEnabled = false;
            }
        }
    }
}
