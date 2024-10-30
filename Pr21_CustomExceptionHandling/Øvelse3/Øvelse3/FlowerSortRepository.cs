using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Øvelse3
{
    internal class FlowerSortRepository
    {
        private List<FlowerSort> flowerSortsList;

        FlowerSortRepository()
        {
            flowerSortsList = new List<FlowerSort>();
        }

        public void AddFlowerSort(string name,Image image, int productionTimeInDays, double halfLife, double size)
        {
            FlowerSort flowerSort = new FlowerSort(name, image, productionTimeInDays, halfLife, size);
            
            flowerSortsList.Add(flowerSort);
        }
    }
}
