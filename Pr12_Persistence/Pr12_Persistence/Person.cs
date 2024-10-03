using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr12_Persistence
{
    public class Person
    {
        
        public string Name {  get; set; }

        public DateTime BirthDate {  get; set; }

        public double Height {  get; set; }

        public bool IsMarried {  get; set; }

        public int NoOfChildren {  get; set; }
        

        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;

        }

        public string MakeTitle()
        {
            return Name + ";" + BirthDate.ToString("dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture) + ";" + Height + ";" + IsMarried + ";" + NoOfChildren;
        }
    }
}
