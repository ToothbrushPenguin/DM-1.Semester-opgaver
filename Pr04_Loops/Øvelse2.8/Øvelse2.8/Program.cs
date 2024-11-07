namespace Øvelse2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = "";
            while (input != "done")
            {
                
                Console.WriteLine("1. Gør dit");
                Console.WriteLine("2. Gør dat");
                Console.WriteLine("3. Gør noget");
                Console.WriteLine("4. Få svar på livet, universet og alting");
                Console.WriteLine();
                Console.WriteLine("(Intast 1, 2, 3 eller 4)");

                input = Console.ReadLine();
                
                string message;

                switch (input)
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
                Console.WriteLine("Punkt {0} er valgt: {1}", input, message);
                Console.ReadLine();
                Console.Clear();
            }

            /*
            string input = "";
            do
            {

                Console.WriteLine("1. Gør dit");
                Console.WriteLine("2. Gør dat");
                Console.WriteLine("3. Gør noget");
                Console.WriteLine("4. Få svar på livet, universet og alting");
                Console.WriteLine();
                Console.WriteLine("(Intast 1, 2, 3 eller 4)");

                input = Console.ReadLine();
                string message;

                switch (input)
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
                Console.WriteLine("Punkt {0} er valgt: {1}", input, message);
                Console.ReadLine();
                Console.Clear();
            }
            while (input != "done");
            */
            
        }
    }
}
