using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Øvelse2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = line1.Text;
            line1.Text = line2.Text;
            line2.Text = line3.Text;
            line3.Text = line4.Text;
            line4.Text = text;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string text = line4.Text;
            line4.Text = line3.Text;
            line3.Text = line2.Text;
            line2.Text = line1.Text;
            line1.Text = text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            line1.Clear();
            line2.Clear();
            line3.Clear();
            line4.Clear();
        }
    }
}