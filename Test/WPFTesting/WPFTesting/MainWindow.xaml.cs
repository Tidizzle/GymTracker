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

namespace WPFTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            
        }

        public enum Buttons {  Button1, Button2 }

        bool Button1Active = false;
        Buttons SelectedButton;

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!Button1Active)
            {
                BitmapImage Image1 = new BitmapImage(new Uri("/Assets/Button1Selected.png", UriKind.Relative));
                Button1_Image.Source = Image1;
                Button1Active = true;
            }
            else
            {
                BitmapImage Image1 = new BitmapImage(new Uri("/Assets/Button1Passive.png", UriKind.Relative));
                Button1_Image.Source = Image1;
                Button1Active = false;
            }
        }

        private void Button1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!Button1Active)
            {
                BitmapImage Image1 = new BitmapImage(new Uri("/Assets/Button1RolledOver.png", UriKind.Relative));
                Button1_Image.Source = Image1;

                
            }
        }

        private void Button1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!Button1Active)
            {
                BitmapImage Image1 = new BitmapImage(new Uri("/Assets/Button1Passive.png", UriKind.Relative));
                Button1_Image.Source = Image1;
            }
        }
    }
}
