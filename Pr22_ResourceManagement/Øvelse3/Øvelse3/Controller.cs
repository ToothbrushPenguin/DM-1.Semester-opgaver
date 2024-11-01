using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    internal class Controller
    {
        public ProductionRepository productionRepository;

        public Controller()
        {
            productionRepository = new ProductionRepository();
        }
    }
}
