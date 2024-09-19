namespace Øvelse2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            while (true) {

                Menu mainMenu = new Menu("Min fantastiske menu");

                // First menu item
                mainMenu.AddMenuItem("1. Gør dit");
                // Second menu item
                mainMenu.AddMenuItem("2. Gør dat");
                // Third menu item
                mainMenu.AddMenuItem("3. Gør noget");
                // Last menu item
                mainMenu.AddMenuItem("4. Få svaret på livet, universet og alting");


                mainMenu.Show();

                int selection = mainMenu.SelectMenuItem();

                if (selection == 0) break;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Gør dit");
                        break;

                    case 2:
                        Console.WriteLine("Gør dat");
                        break;

                    case 3:
                        Console.WriteLine("Gør noget");
                        break;

                    case 4:
                        Console.WriteLine("42");
                        break;

                }

                Console.ReadLine();
            }
        }
    }
}
