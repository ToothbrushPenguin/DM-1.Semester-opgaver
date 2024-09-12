namespace Øvelse_4_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4.1*/
            string navn = "test med test";
            Console.WriteLine(navn.Length);

            /*4.2*/
            Console.WriteLine(navn.Substring(5,3));

            /*4.3*/
            Console.WriteLine(navn.IndexOf('t'));

            /*4.3 extra find nr. 2*/
            Console.WriteLine(navn.IndexOf('t',navn.IndexOf('t')+1));
        }
    }
}
