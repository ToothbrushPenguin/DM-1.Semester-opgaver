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
using System.Windows.Shapes;

namespace TusindFryd
{
    /// <summary>
    /// Interaction logic for DialogBox.xaml
    /// </summary>
    public partial class DialogBox : Window
    {
        public BlomsterSort blomsterSort;
        public DialogBox()
        {
            InitializeComponent();
            
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {

            if (BilledeSti.Text != "" && Name.Text != "" && Produktionstid.Text != "" && Halveringstid.Text != "" && Størrelse.Text != "")
            {
                blomsterSort = new BlomsterSort();
                blomsterSort.Name = Name.Text;
                blomsterSort.PicturePath = BilledeSti.Text;
                blomsterSort.ProductionTime = Convert.ToInt32(Produktionstid.Text);
                blomsterSort.Size = Convert.ToInt32(Størrelse.Text);
                Close();
            }
        }

        private void Fotryd_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }

        private void TypedImage(object sender, KeyboardFocusChangedEventArgs e)
        {
            string imagePath = BilledeSti.Text;

            // Check if the path is valid and the file exists (for local files)
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please enter a valid image path or URL.");
                return;
            }

            try
            {
                // Create a BitmapImage and set it as the source for the Image control
                BitmapImage bitmap = new BitmapImage();

                // If the path is a URI (like a web URL), handle it as such
                if (Uri.TryCreate(imagePath, UriKind.Absolute, out Uri uri))
                {
                    bitmap.BeginInit();
                    bitmap.UriSource = uri;
                    bitmap.EndInit();
                }
                else
                {
                    MessageBox.Show("The specified path does not exist.");
                    return;
                }

                // Display the image in the Image control
                image.Source = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}");
            }

        }
    }
}
