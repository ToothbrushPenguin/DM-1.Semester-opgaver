using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindFryd
{
    public class BlomsterSort
    {
        public string Name;
        public string PicturePath;
        public int ProductionTime;
        public int HalfLifeTime;
        public int Size;

        public string ToString()
        {
            return $"{Name};{ProductionTime};{HalfLifeTime};{Size}";
        }
        
    }
}
