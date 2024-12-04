using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    public class ConcreteSubject : Subject
    {
        private int _state = 0;
        public int State 
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify();  
            }
        }


    }
}
