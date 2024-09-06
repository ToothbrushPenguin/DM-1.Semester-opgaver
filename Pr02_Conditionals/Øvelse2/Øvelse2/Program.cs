namespace Øvelse2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            age -= 10;

            Console.WriteLine(name + " er " + age + " år gammel");

            ;
        }
    }
}
