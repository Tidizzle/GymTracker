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

namespace GymTracker.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Frame LoginFramePub;
        public LoginToAccount LoginInstnc;
        public CreateAccount CreateInstnc;
        public ResetPassword ResPasInstnc;
        public MainWindow Parent;

        public Login(MainWindow ParentWin)
        {
            InitializeComponent();

            LoginFramePub = LoginFrame;
            LoginInstnc = new LoginToAccount(this);
            CreateInstnc = new CreateAccount(this);
            ResPasInstnc = new ResetPassword(this);
            Parent = ParentWin;

            LoginFrame.Content = LoginInstnc;
        }

        public void LoginUser(User Account)
        {
            
        }
    }
}
