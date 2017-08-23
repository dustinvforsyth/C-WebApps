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

namespace wpfEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            myButton.Click += MyButton_Click;
            myButton.Click += MyButton_Click1;
        }

        private void MyButton_Click1(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
            myLabel.Content = "Hello World Again!";
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();

            myLabel.Content = "Hello World";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
