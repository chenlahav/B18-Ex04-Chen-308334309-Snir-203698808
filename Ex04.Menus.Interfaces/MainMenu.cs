using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class MainMenu
    {
        List<MenuItem> m_MenuItems;

        public MainMenu(List<MenuItem> i_MenuItems)
        {
            m_MenuItems = i_MenuItems;
        }

        public void Show()
        {
            Console.WriteLine("Welcome!");
            int selection = 0;
            do
            {
                //TODO: show the options
                Console.Write("Choose one of the options: ");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                while (!result)
                {
                    Console.Write("Invalid input\nChoose one of the options: ");
                    result = int.TryParse(Console.ReadLine(), out selection);
                }
                //TODO: select the user's choice
            }
            while (selection != 0);

            Console.WriteLine("Thank you!\nBye Bye..");
        }
    }
}
