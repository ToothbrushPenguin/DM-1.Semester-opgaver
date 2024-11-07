namespace Øvelse2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hej9+emil2mat-hies+en-165";
            string type;
            int i = 0;
            while (i < str.Length)
            {

                if (char.IsDigit(str[i]))
                {
                    type = "(ciffer)";
                } else {
                    switch (str[i])
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

                Console.WriteLine("{0}: '{1}' {2}", i, str[i], type);

                i++;
            }

        }
    }
}
