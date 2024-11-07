using System.Runtime.CompilerServices;

namespace Øvelse3._2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            do
            {
                bool valid = true;
                Console.WriteLine("Select a Methot:");
                Console.WriteLine("- '+'");
                Console.WriteLine("- '-'");
                Console.WriteLine("- '*'");
                Console.WriteLine("- '/'");

                string op = Console.ReadLine();
                if (op.ToLower() == "done")
                {
                    break;
                }else if(!(calc.isOberator(op)))
                {
                    Console.WriteLine("not an operator");
                    valid = false;
                }


                Console.WriteLine("write your 1. number");
                string nr1In = Console.ReadLine();
                int nr1Out;
                if (nr1In.ToLower() == "done")
                {
                    break;
                }
                else if (!(int.TryParse(nr1In, out nr1Out)))
                {
                    Console.WriteLine("not a number");
                    valid = false;
                }


                Console.WriteLine("write your 2. number");
                string nr2In = Console.ReadLine();
                int nr2Out;
                if (nr2In.ToLower() == "done")
                {
                    break;
                } 
                else if (!(int.TryParse(nr2In, out nr2Out)))
                {
                    Console.WriteLine("not a number");
                    valid = false;
                }

                if (valid)
                {
                    switch (op)
                    {
                        case "+":
                            Console.WriteLine(calc.Add(nr1Out, nr2Out));
                            break;

                        case "-":
                            Console.WriteLine(calc.Sub(nr1Out, nr2Out));
                            break;

                        case "/":
                            Console.WriteLine(calc.Div(nr1Out, nr2Out));
                            break;

                        case "*":
                            Console.WriteLine(calc.Mul(nr1Out, nr2Out));
                            break;
                    }

                }
                
            } while (true);

        }
    }
}
