namespace Øvelse2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hej emil Korsholm mathiesen";
            int i = 0;
            while (i < str.Length)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine("{0}: '{1}'", i, str[i]);
                    
                }
                i++;
            }
        }
    }
}
