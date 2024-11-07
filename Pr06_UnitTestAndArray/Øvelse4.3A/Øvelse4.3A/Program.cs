namespace Øvelse4._3A
{
    internal class Program
    {
        public static bool doseContain(int[] input, int lookFor)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == lookFor)
                {

                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int lookfor;
            if (int.TryParse(Console.ReadLine(), out lookfor))
            {
                int nop = 0;
                if (int.TryParse(Console.ReadLine(), out nop))
                {
                    int[] alder = new int[nop];
                    for (int i = 0; i < alder.Length; i++)
                    {
                        int number = 0;
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            alder[i] = number;
                        }
                        else
                        {
                            i--;
                            Console.WriteLine("et tal var ikke angivet");
                        }

                    }
                    Console.WriteLine(doseContain(alder, lookfor));
                }
                else
                {
                    Console.WriteLine("et tal var ikke angivet");
                }

            }
            else
            {
                Console.WriteLine("et tal var ikke angivet");
            }








        }

        
    }
}
