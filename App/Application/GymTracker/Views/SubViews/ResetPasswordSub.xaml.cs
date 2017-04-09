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
    }
}
