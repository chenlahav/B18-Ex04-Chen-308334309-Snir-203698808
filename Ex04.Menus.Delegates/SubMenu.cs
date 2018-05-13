using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private List<MenuItem> m_MenuItems;
        
        public SubMenu(string i_Title, MenuItem i_Father) : base(i_Title)
        {
            m_MenuItems = new List<MenuItem>();
            m_MenuItems.Add(i_Father);
        }

        public MenuItem GetMenuItem(int i_index)
        {
            return m_MenuItems[i_index];
        }

        public List<MenuItem> GetMenuItems()
        {
            return m_MenuItems;
        }

        public void SetMenuItems(List<MenuItem> i_NewMenuItems)
        {
            m_MenuItems = i_NewMenuItems;
        }

        public void AddItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        public override int? Select(int i_Level, ref SubMenu i_SubMenu)
        {
            i_SubMenu = this;
            return ShowMenuAndGetSelectionUser(i_Level);

        }
        public int ShowMenuAndGetSelectionUser(int i_Level)
        {
            Console.WriteLine($"====== {Title} ====== (level {i_Level})");
            //Console.WriteLine($"Level {i_Level}");

            if (i_Level == 1)
            {
                Console.WriteLine("0 - Exit");
            }

            else
            {
                Console.WriteLine("0 - Back");
            }

            for(int i=1; i<m_MenuItems.Count; i++)
            { 
                Console.WriteLine($"{i} - {m_MenuItems[i].Title}");
            }

            int selection = 0;
            Console.Write("Choose one of the options: ");
            bool result = int.TryParse(Console.ReadLine(), out selection);
            while (!result || selection> m_MenuItems.Count || selection < 0)
            {
                Console.Write("Invalid input\nChoose one of the options: ");
                result = int.TryParse(Console.ReadLine(), out selection);
                //TODO: validate number is less or equal to option number
            }

            return selection;
        }
    }
}
