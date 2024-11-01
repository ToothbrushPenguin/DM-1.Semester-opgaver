using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    internal class ProductionTrayRepository
    {
        private List<ProductionTray> productionTraysList;


        public ProductionTrayRepository()
        {
            productionTraysList = new List<ProductionTray>();
        }

        public void CreateTray(string name, double size)
        {
            ProductionTray pt = new ProductionTray(name, size);
            productionTraysList.Add(pt);
        }

        public ProductionTray GetTray(string name)
        {
            ProductionTray? output = null;
            for (int i = 0; i < productionTraysList.Count; i++)
            {
                if (name == productionTraysList[i].Name)
                {
                    output = productionTraysList[i];
                }
            }

            return output;
        }
    }
}
