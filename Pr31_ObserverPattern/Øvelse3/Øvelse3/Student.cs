using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    public class Student : Observer
    {
        private Academy subject;
        
        public string Message { get; set; }
        
        public string Name {  get; }

        public Student(Academy subject, string name) 
        {
            this.subject = subject;
            Name = name;
        }

        public override void Update()
        {
            Message = subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {subject.Name}");
        }
    }
}
