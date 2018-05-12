using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class MainMenu 
    {
        private SubMenu m_Menu;
        private int m_Level = 1;

        public MainMenu()
        {
            m_Menu = new SubMenu("MainMenu", null);
        }

        public void addMenuItem(MenuItem i_MenuItem)
        {
            m_Menu.AddItem(i_MenuItem);
        }

        public void Show()
        {
            int selection = 0;
            do
            {
                if(m_Level == 1)
                {
                    m_Menu.ShowMenu();
                }

                else
                {
                    m_Menu.GetMenuItem(selection).Select(m_Level);
                }

                Console.Write("Choose one of the options: ");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                while (!result)
                {
                    Console.Write("Invalid input\nChoose one of the options: ");
                    result = int.TryParse(Console.ReadLine(), out selection);
                    //TODO: validate number is less or equal to option number
                }
                m_Level++;
            }
            while (selection != 0);

            Console.WriteLine("Thank you!\nBye Bye..");
        }
    }
}
