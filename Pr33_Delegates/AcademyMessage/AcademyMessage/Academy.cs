using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMessage
{
    public delegate void NotifyHandler();

    public class Academy : Organization
    {
        private string _message;
        public string Name { get; }
        public string Address { get; }

        public NotifyHandler MessageChanged;
        public string Message
        {
            get { return _message; }
            set { _message = value; MessageChanged(); } 
        }

        public Academy(string name, string address) : base(name)
        {
            Name = name;
            Address = address;
        }
        
    }
}
