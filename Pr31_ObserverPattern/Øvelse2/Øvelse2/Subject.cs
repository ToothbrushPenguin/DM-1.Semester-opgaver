using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach (Observer o)
        {
            observers.Add(o);
        }

        public void Detach(Observer o)
        {
            observers.Remove (o);
        }

        public void Notify()
        {

            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
