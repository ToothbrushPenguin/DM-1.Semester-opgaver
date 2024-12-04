using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMessage
{
    public class Student : Person
    {
        private Academy subject { get; set; }

        public string Message { get; set; }

        public string Name { get; }

        public Student(Academy subject, string name) : base(name)
        {
            this.subject = subject;
            Name = name;
        }

        public void Update()
        {
            Message = subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {subject.Name}");
        }
    }
}
