namespace Øvelse3._2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            string input;
            do
            {
                Console.WriteLine("Select a Methot:");
                Console.WriteLine("- 'Add'");
                Console.WriteLine("- 'Sub'");
                Console.WriteLine("- 'Dev'");
                Console.WriteLine("- 'Mul'");

                input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                string op = input;

                Console.WriteLine("write your 1. number");
                input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                string nr1 = input;

                Console.WriteLine("write your 2. number");
                input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                string nr2 = input;

                switch (op)
                {
                    case "Add":
                        Console.WriteLine(calc.Add(int.Parse(nr1), int.Parse(nr2)));
                        break;
                    case "Sub":
                        break;
                    case "Dev":
                        break;
                    case "Mul":
                        break;
                    default:
                        break;
                }
            } while (true);
            



        }
    }
}
