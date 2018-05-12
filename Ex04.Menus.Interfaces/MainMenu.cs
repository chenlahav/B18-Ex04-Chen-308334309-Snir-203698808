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
                    selection = m_Menu.ShowMenuAndGetSelectionUser();
                }

                else
                {
                    m_Menu.GetMenuItem(selection).Select(m_Level);
                }

                if (selection == 0)
                {
                    m_Level--;
                }
                
                else
                {
                    m_Level++;
                }
            }
            while (!(selection == 0 && m_Level == 1));

            Console.WriteLine("Thank you!\nBye Bye..");
        }
    }
}
