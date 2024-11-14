using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAndMVVM1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string MyLabelText { get; set; }

        public string MyTextBoxText { get; set; }

        public MainViewModel() 
        {
            MyLabelText = "Text not set yet";
            MyTextBoxText = "Text not set yet";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
