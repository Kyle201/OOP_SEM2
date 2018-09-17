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

namespace Cart
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

        private void Add(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Add(TextBox.Text);
            TextBox.Clear();

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Remove(ListBox1.SelectedItem);
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender,EventArgs e)
        {
            try
            {
                TextBox.Text = ListBox1.SelectedItem.ToString();
            }
            catch
            {

            }
     

        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            int index = ListBox1.SelectedIndex;
            ListBox1.Items.RemoveAt(index);
            ListBox1.Items.Insert(index, TextBox.Text);
            
        }
    }
}
