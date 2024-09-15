namespace Øvelse2._12_2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arithmetic expression (e.g., 15+15-5):");
            string input = Console.ReadLine();

            int result = 0;
            int currentNumber = 0;
            char lastOperator = '+';

            for (int i = 0; i < input.Length; i++)
            {
                string type = GetType(input[i]);

                if (type == "(ciffer)")
                {
                    currentNumber = currentNumber * 10 + (input[i] - '0');
                }
                else if (type == "(operator)")
                {
                    result = PerformOperation(result, currentNumber, lastOperator);
                    currentNumber = 0;
                    lastOperator = input[i];
                }
                else
                {
                    Console.WriteLine("{0}: '{1}' {2}", i, input[i], type);
                }
            }

            result = PerformOperation(result, currentNumber, lastOperator);
            Console.WriteLine($"Result: {result}");
        }

        private static string GetType(char input)
        {
            string type;
            if (char.IsDigit(input))
            {
                type = "(ciffer)";
            }
            else
            {
                switch (input)
                {
                    case '+':
                    case '-':
                        type = "(operator)";
                        break;
                    default:
                        type = "(ukendt)";
                        break;
                }
            }
            return type;
        }

        private static int PerformOperation(int result, int currentNumber, char operation)
        {
            switch (operation)
            {
                case '+':
                    return result + currentNumber;
                case '-':
                    return result - currentNumber;
                default:
                    return currentNumber;
            }
        }
    }
}
