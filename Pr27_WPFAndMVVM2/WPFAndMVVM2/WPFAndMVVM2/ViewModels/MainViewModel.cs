 using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();
        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !
        public ObservableCollection<PersonViewModel> PersonsVM { get; set; } = new ObservableCollection<PersonViewModel>();

        private PersonViewModel _selectedPersonVM;
        public PersonViewModel SelectedPersonVM {
            get 
            { 
                return _selectedPersonVM; 
            } 
            set 
            { 
                _selectedPersonVM = value;
                OnPropertyChanged(nameof(SelectedPersonVM));
            }
        }

        public MainViewModel()
        {
            foreach (Person person in personRepo.GetAll()) {
                PersonsVM.Add(new PersonViewModel(person));
            }
            
        }

        public void AddDefaultPerson()
        {
            Person person = personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            PersonViewModel newPerson = new PersonViewModel(person);
            PersonsVM.Add(newPerson);
            SelectedPersonVM = newPerson;


        }

        public void DeleteSelectedPerson()
        {
            if (SelectedPersonVM != null)
            {
                SelectedPersonVM.Delete(personRepo);
                PersonsVM.Remove(SelectedPersonVM);
            }


        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        

    }
}
