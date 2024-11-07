namespace Øvelse2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hej";
            int i = 0;
            do
            {
                Console.WriteLine("{0}: '{1}'", i, str[i]);
                i++;
            }
            while (i < str.Length);
            
        }
    }
}
