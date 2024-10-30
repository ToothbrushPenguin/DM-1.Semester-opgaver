using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Øvelse3
{
    public class FlowerSort
    {
        public string Name;
        public int ProductionTimeInDays;
        public double HalfLife;
        public double Size;
        public Image Billede;

        public FlowerSort(string name, Image billede, int productionTimeInDays, double halfLife,double size)
        {
           Name = name;
           Billede = billede;
           ProductionTimeInDays = productionTimeInDays;
           HalfLife = halfLife;
           Size = size;

        }
    }
}
