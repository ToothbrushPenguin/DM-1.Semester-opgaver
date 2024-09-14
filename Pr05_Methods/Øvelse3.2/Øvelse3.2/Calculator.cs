using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3._2
{
    internal class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public double Div(int x, int y)
        {
            return (double)x / (double)y;
        }
        
        public int Mul(int x, int y)
        {
            return x * y;
        }

    }

}
