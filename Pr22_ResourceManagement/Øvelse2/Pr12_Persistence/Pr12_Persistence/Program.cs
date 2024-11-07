namespace Pr12_Persistence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            Person person2 = new Person("bob", new DateTime(1944, 8, 24), 175.9, false, 4);
            Person[] persons = [ person, person2 ];

            DataHandler handler = new DataHandler("Data.txt");
            handler.SavePerson(person);

            Console.Write("Writing Person: ");
            Console.WriteLine(person.MakeTitle());

            handler.SavePersons(persons);

            Person[] people = handler.LoadPersons();
            foreach(Person p in people)
            {
                Console.WriteLine(p.MakeTitle());
            }


            Console.ReadLine();
        }

    }
}
