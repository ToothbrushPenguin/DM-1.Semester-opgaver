namespace Øvelse2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hej9emil2ma thie sen165";
            int i = 0;
            while (i < str.Length)
            {
                if (char.IsDigit(str[i]))
                {
                    Console.WriteLine("{0}: '{1}'", i, str[i]);
                }
                
                i++;
            }
        }
    }
}
