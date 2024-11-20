using DataCommandBindingListBox.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCommandBindingListBox.viewModels
{
    public class ProductRepo
    {

        private List<Product> products = new List<Product>();

        public ProductRepo() 
        {
            products.Add(new Product("Apple", 7.95));
            products.Add(new Product("Orange", 5.50));
            products.Add(new Product("Banana", 8.25));
        }

        public void AddProduct(string name, double price)
        {
            products.Add(new Product(name, price));
        }

        public Product GetProduct(int id)
        {
            Product result = null;
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    result = product;
                }
            }
            return result;
            
        }

        public List<Product> GetAllProducts() 
        {
            return products;
        }
    }
}
