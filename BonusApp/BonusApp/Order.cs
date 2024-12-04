using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus;

        private List<Product> products = new List<Product>();

        public void AddProduct(Product p)
        {
            if (p != null)
            {
                products.Add(p);
            }
        }
        public double GetValueOfProducts()
        {
            double valueOfProducts = 0.0;
            foreach (Product p in products) 
            {
                valueOfProducts += p.Value;
            }
            return valueOfProducts;
        }
    

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }


        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
