using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                using (StreamWriter stream = new StreamWriter(DataFileName))
                {
                    stream.WriteLine(person.MakeTitle());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }


        public Person LoadPerson()
        {
            
            try
            {
                string line;
                using (StreamReader stream = new StreamReader(DataFileName))
                {
                    line = stream.ReadLine();
                }

                string[] list = line.Split(";");

                return new Person(list[0], DateTime.Parse(list[1]), double.Parse(list[2]), bool.Parse(list[3]), int.Parse(list[4]));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }
        }

        public void SavePersons(Person[] persons)
        {
            try
            {
                StreamWriter stream = new StreamWriter(DataFileName);
                foreach (Person person in persons)
                {
                    stream.WriteLine(person.MakeTitle());
                }
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        public Person[] LoadPersons()
        {

            try
            {
                string line;
                string fullLine = "";
                

                StreamReader stream = new StreamReader(DataFileName);
                line = stream.ReadLine();
                
                while (line != null)
                {
                    fullLine += line;
                    fullLine += "\r";
                    line = stream.ReadLine();
                }

                stream.Close();

                string[] fullList = fullLine.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                Person[] persons = new Person[fullList.Length-1];

                for (int i = 0; fullList.Length-1 > i; i++)
                {
                    string[] list = fullList[i].Split(";");
                    Person p = new Person(list[0], DateTime.Parse(list[1]), double.Parse(list[2]), bool.Parse(list[3]), int.Parse(list[4]));
                    persons[i] = p;
                }
                
                return persons;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }


            
        }
    }
}
