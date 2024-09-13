namespace Øvelse2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "10+15-5kkk";

            string[] type = new string[str.Length];
            int i = 0;
            while (i < str.Length)
            {

                if (char.IsDigit(str[i]))
                {
                    type[i] = "(ciffer)";
                }
                else
                {
                    switch (str[i])
                    {
                        case '+':
                        case '-':
                            type[i] = "(operator)";
                            break;
                        default:
                            type[i] = "(ukendt)";
                            Console.WriteLine("{0}: '{1}' {2}", i, str[i], type[i]);
                            break;
                    }
                }
                i++;
            }

        }
    }
}