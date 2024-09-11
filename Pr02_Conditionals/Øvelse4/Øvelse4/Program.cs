using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Øvelse4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("1. Gør dit");
            Console.WriteLine("2. Gør dat");
            Console.WriteLine("3. Gør noget");
            Console.WriteLine("4. Få svar på livet, universet og alting");
            Console.WriteLine();
            Console.WriteLine("(Intast 1, 2, 3 eller 4)");

            string choice = Console.ReadLine();
            string message;
          
            switch (choice)
            {
                case "1":
                    message = "Gør dit";
                    break;
                case "2":
                    message = "Gør dat";
                    break;
                case "3":
                    message = "Gør noget";
                    break;
                case "4":
                    message = "42";
                    break;
                default:
                    message = "Forkert valg";
                    break;
            }

            Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
        }
    }
}
