namespace Øvelse3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Academy academy = new Academy("UCL");


            Student student1 = new Student(academy, "Jens");
            Student student2 = new Student(academy, "Niels");
            Student student3 = new Student(academy, "Susan");


            academy.Attach(student1);
            academy.Attach(student2);
            academy.Attach(student3);


            academy.Message = "Så er der julefrokost!";


            academy.Detach(student2);


            academy.Message = "Så er der fredagsbar!";


            Console.ReadLine();

        }
    }
}
