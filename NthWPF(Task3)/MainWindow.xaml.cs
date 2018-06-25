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
using NthWPF_Task3_.WPFAsync;


namespace NthWPF_Task3_
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrimeButton_Click(object sender, RoutedEventArgs e)
        {
            int input = int.Parse(nthNumber.Text);

            label.Content = Prime.WPFAsync(input).ToString;
        }

    }
}
