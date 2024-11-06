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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();

            UpdateUi();


        }

        private void newP_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            UpdateUi();
        }
        private void deleteP_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
        }
        private void up_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            UpdateUi();
        }
        private void down_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            UpdateUi();
        }
        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.FirstName = firstName.Text;
            UpdateUi();
        }
        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.LastName = lastName.Text;
            UpdateUi();
        }
        private void age_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(age.Text, out int agei);
            controller.CurrentPerson.Age = agei;
            UpdateUi();
        }

        private void tlf_TextChanged(object sender, TextChangedEventArgs e)
        {
            controller.CurrentPerson.TelephoneNo = tlf.Text;
            UpdateUi();
        }

        private void ClearText()
        {
            firstName.Clear();
            lastName.Clear();
            age.Clear();
            tlf.Clear();
        }
        private void UpdateUi()
        {
            countLable.Content = $"Person Count {controller.PersonCount}";
            indexLable.Content = $"index {controller.PersonIndex}";

            if (controller.PersonCount <= 0)
            {

                firstName.IsEnabled = false;
                lastName.IsEnabled = false;
                age.IsEnabled = false;
                tlf.IsEnabled = false;


                deleteP.IsEnabled = false;
                up.IsEnabled = false;
                down.IsEnabled = false;

            }
            else
            {
                firstName.IsEnabled = true;
                lastName.IsEnabled = true;
                age.IsEnabled = true;
                tlf.IsEnabled = true;


                deleteP.IsEnabled = true;
                up.IsEnabled = true;
                down.IsEnabled = true;

                firstName.Text = controller.CurrentPerson.FirstName;
                lastName.Text = controller.CurrentPerson.LastName;
                age.Text = controller.CurrentPerson.Age.ToString();
                tlf.Text = controller.CurrentPerson.TelephoneNo;

            }
        }

        
    }
}
