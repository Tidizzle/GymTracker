using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
using GymTracker.Views.SubViews;

namespace GymTracker.Views
{
    /// <summary>
    /// Interaction logic for ResetPassword.xaml
    /// </summary>
    public partial class ResetPassword : Page
    {
        private ResetFindAcct FindAcctInstnc;
        private ResetSecurityQues SecQuesInstnc;
        private ResetPasswordSub PassResetInstnc;
        private frameMode ButtonMode;
        private enum frameMode { Find, Question, Reset}

        private User foundUser;

        private Login ParentWin;

        public ResetPassword(Login parent)
        {
            InitializeComponent();
            ParentWin = parent;
            FindAcctInstnc = new ResetFindAcct(this);

            ResetFrame.Content = FindAcctInstnc;
            FrameButton.Content = "Find Account";
            ButtonMode = frameMode.Find;
        }

        private void FrameButton_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonMode == frameMode.Find)
            {
                var query = from user in AppState.Userlist
                    where user.Username == FindAcctInstnc.FindUNTextbox.Text
                    select user;
                var i = 0;
                foreach (var user in query)
                    i++;

                if (i == 0)
                {
                    FindAcctInstnc.FindUNTextbox.Clear();
                    MessageBox.Show("Username Not Found", "Reset Password Error", MessageBoxButton.OK);
                }
                else
                {
                    //Set frame inst to sec ques and use arg of queried user
                    foundUser = new User();

                    foreach (var user in query)
                        foundUser = user;
                    
                    SecQuesInstnc = new ResetSecurityQues(this, foundUser);
                    ResetFrame.Content = SecQuesInstnc;
                    ButtonMode = frameMode.Question;
                    FrameButton.Content = "Submit";
                    FrameButton.IsEnabled = false;
                }
            }
            else if(ButtonMode == frameMode.Question)
            {
                if (SecQuesInstnc.ResettingUser.SecurityAns.ToUpper() == SecQuesInstnc.SecAnsBox.Text.ToUpper())
                {
                    PassResetInstnc = new ResetPasswordSub(this,foundUser);
                    ResetFrame.Content = PassResetInstnc;
                    ButtonMode = frameMode.Reset;
                    FrameButton.IsEnabled = false;
                    
                }
                else
                {
                    SecQuesInstnc.AnswerTextBox.Clear();
                    MessageBox.Show("Incorrect Answer", "Security Question Error", MessageBoxButton.OK);
                }
            }
            else if (ButtonMode == frameMode.Reset)
            {
                if (PassResetInstnc.PasswordBox.Password == PassResetInstnc.PasswordConfimBox.Password)
                {
                    AppState.DbCon.Open();
                    var cmd = new SQLiteCommand();
                    cmd.CommandText =
                        $"UPDATE `users` SET `password`='{PassResetInstnc.PasswordBox.Password}' WHERE `username`='{PassResetInstnc.resettingUser.Username}';";
                    cmd.Connection = AppState.DbCon;
                    cmd.ExecuteNonQuery();
                    AppState.DbCon.Close();
                    MessageBox.Show("Password Reset", "Password Reset Sucessful", MessageBoxButton.OK);
                    AppState.LoadData();

                    PassResetInstnc.PasswordBox.Clear();
                    PassResetInstnc.PasswordConfimBox.Clear();
                    SecQuesInstnc.AnswerTextBox.Clear();
                    ResetFrame.Content = FindAcctInstnc;
                    ParentWin.LoginFrame.Content = ParentWin.LoginInstnc;
                }
                else
                {
                    PassResetInstnc.PasswordBox.Clear();
                    PassResetInstnc.PasswordConfimBox.Clear();
                    MessageBox.Show("Passwords do not match.", "Password Reset Error", MessageBoxButton.OK);
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ParentWin.LoginFrame.Content = ParentWin.LoginInstnc;
            ResetFrame.Content = FindAcctInstnc;
            FrameButton.Content = "Find Account";
            ButtonMode = frameMode.Find;
            FindAcctInstnc.FindUNTextbox.Clear();
        }
    }
}
