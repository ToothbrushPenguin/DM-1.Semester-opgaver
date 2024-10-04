using System;
using System.Globalization;

namespace Pr12_Persistence
{
    public class Person
    {
        private string _name;
        private DateTime _birthDate;
        private double _height;
        private int _noOfChildren;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Navn må ikke være tomt.");
                }
                _name = value;
            }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value < new DateTime(1900, 1, 1))
                {
                    throw new Exception("Fødselsdatoen må ikke være før 1. januar 1900.");
                }
                _birthDate = value;
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Højden skal være større end 0.");
                }
                _height = value;
            }
        }

        public bool IsMarried { get; set; }

        public int NoOfChildren
        {
            get { return _noOfChildren; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Antallet af børn må ikke være negativt.");
                }
                _noOfChildren = value;
            }
        }

        // Constructorer
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }

        public Person(string name, DateTime birthDate, double height, bool isMarried)
            : this(name, birthDate, height, isMarried, 0) { }

        // MakeTitle-metoden formaterer outputtet i overensstemmelse med enhedstests
        public string MakeTitle()
        {
            return _name + ";" + _birthDate.ToString("dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture) + ";" +
                   _height.ToString("F1", new CultureInfo("da-DK")) + ";" + IsMarried + ";" + _noOfChildren;
        }
    }
}
