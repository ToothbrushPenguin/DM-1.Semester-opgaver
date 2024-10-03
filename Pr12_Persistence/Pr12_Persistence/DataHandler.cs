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
    }
}
