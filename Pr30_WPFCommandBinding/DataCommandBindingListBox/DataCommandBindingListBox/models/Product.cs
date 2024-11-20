using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCommandBindingListBox.models
{
    public class Product
    {
        private static int idCount = 0;

        public int Id { get; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public double Price { get; set; }


        
        
        public Product(string name, double price)
        {
            Id = idCount++;
            Name = name;
            Price = price;
        }

    }
}
