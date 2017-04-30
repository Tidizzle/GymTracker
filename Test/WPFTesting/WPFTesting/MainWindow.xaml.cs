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


        private void RedButton_OnClick(object sender, RoutedEventArgs e)
        {
            var leftcurrent = double.Parse(LeftColumn.Width.ToString());
            leftcurrent += 25;


            LeftColumn.Width = new GridLength(leftcurrent);

            var rightcurrent = double.Parse(LeftColumn.Width.ToString());
            rightcurrent -= 25;

            RightColumn.Width = new GridLength(rightcurrent);



        }

        private void BlueButton_OnClick(object sender, RoutedEventArgs e)
        {

            var leftcurrent = double.Parse(LeftColumn.Width.ToString());
            leftcurrent -= 25;


            LeftColumn.Width = new GridLength(leftcurrent);

            var rightcurrent = double.Parse(LeftColumn.Width.ToString());
            rightcurrent += 25;

            RightColumn.Width = new GridLength(rightcurrent);


        }
    }
}
