
using TotallySafeLib;
namespace Pr21_CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int posValue = TotallySafe.GetValueAtPosition(-2);
                Console.WriteLine(posValue);
            }
            catch (NegativeIndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }



            try
            {
                TotallySafe.Divider(0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                TotallySafe.StringToInt("s");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();





        }

    }
}
