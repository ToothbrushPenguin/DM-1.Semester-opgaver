namespace Øvelse4._2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alder = { 24, 24, 26, 38, 23, 27 };
            double avarage = 0;
            for (int i = 0; i < alder.Length; i++)
            {
                Console.WriteLine(alder[i]);
                avarage += alder[i];
            }
            Console.WriteLine(avarage/alder.Length);
        }
    }
}
