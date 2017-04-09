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
using GymTracker.Classes;

namespace GymTracker.Views.SubViews
{
    /// <summary>
    /// Interaction logic for ResetPasswordSub.xaml
    /// </summary>
    public partial class ResetPasswordSub : Page
    {
        private ResetPassword ParentWin;
        internal PasswordBox PasswordBox;
        internal PasswordBox PasswordConfimBox;
        internal User resettingUser;

        public ResetPasswordSub(ResetPassword parent, User resettingUser)
        {
            InitializeComponent();
            ParentWin = parent;

            PasswordBox = PasswordBoxLocal;
            PasswordConfimBox = PasswordConfBox;
        }

        private bool PassBoxEntered = false;
        private bool ConfBoxEntered = false;

        private void PasswordBoxLocal_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordBox.Password))
            {
                PassBoxEntered = true;
                if (ConfBoxEntered)
                {
                    ParentWin.FrameButton.IsEnabled = true;
                }
            }
            else
            {
                ParentWin.FrameButton.IsEnabled = false;
                PassBoxEntered = false;
            }
        }

        private void PasswordConfBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordConfBox.Password))
            {
                ConfBoxEntered = true;
                if (PassBoxEntered)
                {
                    ParentWin.FrameButton.IsEnabled = false;
                }
            }
        }
    }
}
