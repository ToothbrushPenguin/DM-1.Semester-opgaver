using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallySafeLib
{
    public class NegativeIndexOutOfRangeException : Exception
    {

        public NegativeIndexOutOfRangeException()
        {
        
        }

        public NegativeIndexOutOfRangeException(string message) : base(message) 
        { 

        }
        public NegativeIndexOutOfRangeException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
