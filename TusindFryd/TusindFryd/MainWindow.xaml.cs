using System.Reflection.Emit;
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

namespace TusindFryd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BlomsterSort> flowerSorts;
        public BlomsterSort BlomsterSortToADD { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<BlomsterSort>();
        }
        

        private void Transporter_Click(object sender, RoutedEventArgs e)
        {
          DialogBox dialogBox = new DialogBox();
            dialogBox.ShowDialog();
            BlomsterSortList.Items.Add(dialogBox.blomsterSort.ToString());

        }
    }
}