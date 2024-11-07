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

            int choice;
            string message;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        message = "Gør dit";
                        break;
                    case 2:
                        message = "Gør dat";
                        break;
                    case 3:
                        message = "Gør noget";
                        break;
                    case 4:
                        message = "42";
                        break;
                    default:
                        message = "Forkert valg";
                        choice = -1;
                        break;
                }


            }
            else {
                message = "Forkert valg";
                choice = -1;
            }
            Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
        }
    }
}
