using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class SubMenu : MenuItem
    {
        private List<MenuItem> m_MenuItems;
        private int m_CurrentLevel;
        
        public SubMenu(string i_Title, MenuItem i_Father) : base(i_Title)
        {
            m_MenuItems = new List<MenuItem>();
            m_MenuItems.Add(i_Father);
        }

        public MenuItem GetMenuItem(int i_index)
        {
            return m_MenuItems[i_index];
        }
        public void AddItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public override int Select(int i_Level)
        {
            m_CurrentLevel = i_Level;
            return ShowMenuAndGetSelectionUser();

        }
        public int ShowMenuAndGetSelectionUser()
        {
            int i = 1;

            Console.WriteLine(Title);
            Console.WriteLine($"Level {m_CurrentLevel}");

            if (m_CurrentLevel == 1)
            {
                Console.WriteLine("0 - Exit");
            }

            else
            {
                Console.WriteLine("0 - Back");
            }

            foreach (MenuItem item in m_MenuItems)
            {
                Console.WriteLine($"{i} - {item.Title}");
                i++;
            }

            int selection = 0;
            Console.Write("Choose one of the options: ");
            bool result = int.TryParse(Console.ReadLine(), out selection);
            while (!result)
            {
                Console.Write("Invalid input\nChoose one of the options: ");
                result = int.TryParse(Console.ReadLine(), out selection);
                //TODO: validate number is less or equal to option number
            }

            return selection;
        }
    }
}
