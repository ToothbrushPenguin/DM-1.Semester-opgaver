using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    internal class ProductionRepository
    {
        private List<Production> productionsList;

        public FlowerSortRepository flowerSortRepository;
        public ProductionTrayRepository productionTrayRepository;

        public ProductionRepository() 
        { 
            productionsList = new List<Production>();
        }

        public void Add(string drivhus, string produktionsbakke, string blomstersort, int startAntal, DateTime startDato)
        {

            FlowerSort flowerSort = flowerSortRepository.GetSort(blomstersort);
            ProductionTray productionTray = productionTrayRepository.GetTray(produktionsbakke);


            Production p = new Production(drivhus, productionTray, flowerSort, startAntal, startDato);
            productionsList.Add(p);
        }
    }

}
