using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Pr12_Persistence
{
    public class DataHandler
    {
        public string DataFileName { get; }

        public DataHandler(string dataFileName)
        {
            DataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            
            using (StreamWriter stream = new StreamWriter(DataFileName))
            {
                stream.WriteLine(person.MakeTitle());
            }
            
        }


        public Person LoadPerson()
        {
            Person? output = null;
            
            string? line;
            using (StreamReader stream = new StreamReader(DataFileName))
            {
                line = stream.ReadLine();
            }
            
            string[] list = line.Split(";");

            output = new Person(list[0], DateTime.Parse(list[1]), double.Parse(list[2]), bool.Parse(list[3]), int.Parse(list[4]));
            
            return output;
        }

        public void SavePersons(Person[] persons)
        {
            using (StreamWriter stream = new StreamWriter(DataFileName))
            {
                foreach (Person person in persons)
                {
                    stream.WriteLine(person.MakeTitle());
                }
            }

        }

        public Person[] LoadPersons()
        {
            Person[]? output = null;
           
            using (StreamReader stream = new StreamReader(DataFileName))
            {
                string line;
                string fullLine = "";

                line = stream.ReadLine();
                while (line != null)
                {
                    fullLine += line;
                    fullLine += "\r";
                    line = stream.ReadLine();
                }

                string[] fullList = fullLine.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                Person[] persons = new Person[fullList.Length - 1];

                for (int i = 0; fullList.Length - 1 > i; i++)
                {
                    string[] list = fullList[i].Split(";");
                    Person p = new Person(list[0], DateTime.Parse(list[1]), double.Parse(list[2]), bool.Parse(list[3]), int.Parse(list[4]));
                    persons[i] = p;
                }
                output = persons;
            }
            return output;

        }
    }
}
