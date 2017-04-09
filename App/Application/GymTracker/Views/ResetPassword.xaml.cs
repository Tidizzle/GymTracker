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
using GymTracker.Views.SubViews;

namespace GymTracker.Views
{
    /// <summary>
    /// Interaction logic for ResetPassword.xaml
    /// </summary>
    public partial class ResetPassword : Page
    {
        private ResetFindAcct FindAcctInstnc;
        private frameMode ButtonMode;
        private enum frameMode { Find, Reset}

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

            }
            else
            {
                
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ParentWin.LoginFrame.Content = ParentWin.LoginInstnc;
        }
    }
}
