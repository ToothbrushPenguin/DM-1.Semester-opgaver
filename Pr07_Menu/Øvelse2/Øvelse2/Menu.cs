using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    public class Menu
    {
        public string title;

        private MenuItem[] menuItems = new MenuItem[100];

        private int itemCount = 0;

        public Menu(string ti)
        {
            title = ti;
        }

        public void AddMenuItem(string menuTitle)
        {
            MenuItem mi = new MenuItem(menuTitle);
            menuItems[itemCount] = mi;
            itemCount++;
        }

        public void Show()
        {
            Console.WriteLine(title);
            for (int i = 0; i < itemCount; i++)
            {
                    Console.WriteLine(menuItems[i].title);
            }
            Console.WriteLine("(Tryk 'mellrum' eller '0' for at afslutte)");
        }






    }
}
