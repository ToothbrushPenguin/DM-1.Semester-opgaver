namespace Øvelse2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hej";
            int i = 0;
            while (i< str.Length)
            {
                Console.WriteLine("{0}: '{1}'",i , str[i]);
                i++;
            }
        }
    }
}
