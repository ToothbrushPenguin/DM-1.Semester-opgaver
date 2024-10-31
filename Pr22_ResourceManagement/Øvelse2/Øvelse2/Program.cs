namespace Øvelse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "testfile.txt";

            StreamWriter? sw = null;
            try
            {
                sw = new StreamWriter(filename);
                sw.WriteLine("testinput");

            }
            finally 
            {
                sw?.Dispose();
            }

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filename);
                Console.WriteLine(sr.ReadLine());
            }
            finally
            {
                sr?.Dispose();
            }
        }
    }
}
