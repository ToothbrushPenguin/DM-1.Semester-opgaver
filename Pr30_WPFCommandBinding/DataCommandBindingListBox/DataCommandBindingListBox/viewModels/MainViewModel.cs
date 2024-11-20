using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCommandBindingListBox.models;

namespace DataCommandBindingListBox.viewModels
{
    public class MainViewModel
    {
        private ProductRepo productsRP = new ProductRepo();
        public ObservableCollection<ProductViewModel> ProductsVM { get; set; } = new ObservableCollection<ProductViewModel>();

        public MainViewModel() 
        {
            foreach( Product product in productsRP.GetAllProducts())
            {
                ProductsVM.Add(new ProductViewModel(product));
            }
        }
        
    }
}
