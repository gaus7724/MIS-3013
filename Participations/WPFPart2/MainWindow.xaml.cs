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

namespace WPFPart2
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

       


        private void btn_Odds_Checked(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(1);
            listBox.Items.Add(3);
            listBox.Items.Add(5);
            listBox.Items.Add(7);
            listBox.Items.Add(9);

        }

        private void txt_Max_TextChanged(object sender, TextChangedEventArgs e)
        {
        

        }

        private void btn_Even_Checked(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(2);
            listBox.Items.Add(4);
            listBox.Items.Add(6);
            listBox.Items.Add(8);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
