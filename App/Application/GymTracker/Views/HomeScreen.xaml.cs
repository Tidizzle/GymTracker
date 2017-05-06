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
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Page
    {
        public HomeScreen()
        {
            InitializeComponent();
            extended = true;
        }

        private bool extended;
        private GridLength maxWidth = new GridLength(266);
        private GridLength minWidth = new GridLength(100);

        private void ChangeSizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (extended)
            {
                MenuBar.Width = minWidth;
                extended = false;
                ChangeSizeButton.Content = ">";
                ChangeSizeButton.Margin = new Thickness(0,0,0,0);
                ChangeSizeButton.HorizontalAlignment = HorizontalAlignment.Center;
            }
            else
            {
                MenuBar.Width = maxWidth;
                extended = true;
                ChangeSizeButton.Content = "<";
                ChangeSizeButton.Margin = new Thickness(0,0,20,0);
                ChangeSizeButton.HorizontalAlignment = HorizontalAlignment.Right;
            }
        }


        private void Menu_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (!extended)
            {
                MenuBar.Width = maxWidth;
                extended = true;
            }
        }

        private void Menu_OnMouseLeave(object sender, MouseEventArgs e)
        {
            if (extended)
            {
                MenuBar.Width = minWidth;
                extended = false;
            }
        }
    }
}
