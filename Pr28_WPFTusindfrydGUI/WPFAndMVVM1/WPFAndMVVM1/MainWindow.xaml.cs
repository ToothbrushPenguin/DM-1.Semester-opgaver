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

namespace WPFAndMVVM1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainViewModel mvm = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = mvm;

            Binding binding = new Binding("Text");
            //binding.Mode = BindingMode.OneTime; Når man kører programmet vil den opdatere TB2 1 gang
            //binding.Mode = BindingMode.OneWay; Den er kun den ene box der updatere den anden = TB3 -> TB2
            //binding.Mode = BindingMode.OneWayToSource; Nu er det sourcen der bliver ændret fra TB2 -> TB3
            binding.Mode = BindingMode.TwoWay; //Begge boxe kan ændre hinanden TB3 <-> TB2
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            binding.Source = TB3;
            TB2.SetBinding(TextBox.TextProperty, binding);

            Binding bindingSlider = new Binding("Value");

            bindingSlider.Mode = BindingMode.TwoWay;
            bindingSlider.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            bindingSlider.Source = Slider;
            TB4.SetBinding(TextBox.TextProperty, bindingSlider);

            Binding labelBinding = new Binding();
            labelBinding.UpdateSourceTrigger = UpdateSourceTrigger.Explicit;

            labelBinding.Source = mvm.MyLabelText;
            Label2.SetBinding(Label.ContentProperty, labelBinding);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mvm.MyLabelText = DateTime.Now.ToString();
        }
    }
}