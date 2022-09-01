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

namespace calculator
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

        private void OnClickAdd(object sender, RoutedEventArgs e)
        {
            int value1 = Convert.ToInt32(TextEdit_value1.Text);
            int value2 = Convert.ToInt32(TextEdit_value2.Text);
            int sum = value1 + value2;
            TextEdit_result.Text = Convert.ToString(sum);
        }

        private void Onclicksub(object sender, RoutedEventArgs e)
        {
            int value1 = Convert.ToInt32(TextEdit_value1.Text);
            int value2 = Convert.ToInt32(TextEdit_value2.Text);
            int sub = value1 - value2;
            TextEdit_result.Text = Convert.ToString(sub);
        }
    }
}
