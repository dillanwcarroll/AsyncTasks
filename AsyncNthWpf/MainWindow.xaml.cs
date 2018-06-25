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
using ClassLibrary;

namespace AsyncNthWpf
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

        public async static void FindPrime(int n, TextBox tb)
        {
            var prime = new Prime();
            var result = await Prime.testWPFAsync(n);
            tb.Text = result.ToString();
        }

        public async static void FindPrime2(int n, TextBox tb)
        {
            var prime = new Prime();
            var result = await Prime.testWPFAsync(n);
            tb.Text = result.ToString();
        }

        private void findPrime_Click(object sender, RoutedEventArgs e)
        {
            FindPrime(int.Parse(input.Text), result);

        }

        private void ProveAsync_Click(object sender, RoutedEventArgs e)
        {
            FindPrime2(int.Parse(input2.Text), result);
        }
    }
}
