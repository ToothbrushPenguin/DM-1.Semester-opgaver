using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    internal class Production
    {
        public string Drivhus;
        public ProductionTray Produktionsbakke;
        public FlowerSort Blomstersort;
        public int StartAntal;
        public DateTime StartDato;

        public Production(string drivhus, ProductionTray produktionsbakke, FlowerSort blomstersort,int startAntal, DateTime startDato) 
        {
            Drivhus = drivhus;
            Produktionsbakke = produktionsbakke;
            Blomstersort = blomstersort;
            StartAntal = startAntal;
            StartDato = startDato;
        }
    }
}
