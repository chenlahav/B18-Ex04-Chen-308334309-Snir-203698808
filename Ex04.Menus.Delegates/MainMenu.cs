using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu 
    {
        private SubMenu m_Menu;
        private int m_Level = 1;

        public MainMenu()
        {
            m_Menu = new SubMenu("MainMenu", null);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_Menu.AddItem(i_MenuItem);
        }

        public SubMenu GetSubMenu()
        {
            return m_Menu;
        }

        public void Show()
        {
            int selection;
            SubMenu currentMenuItem = m_Menu;

            Console.Clear();

            //selection = m_Menu.ShowMenuAndGetSelectionUser(m_Level);
            selection =(int) m_Menu.Select(m_Level, ref currentMenuItem);

            while (true)
            {
                Console.Clear();
                //check for exit selection
                if(m_Level== 1 && selection == 0)
                {
                    break;
                }

                //check for back selection
                if ((m_Level != 1 && selection == 0))
                {
                    m_Level--;
                    currentMenuItem = (SubMenu)currentMenuItem.GetMenuItem(selection);
                }
                else
                {
                    if (currentMenuItem.GetMenuItem(selection) is SubMenu)
                    {
                        currentMenuItem = (SubMenu)currentMenuItem.GetMenuItem(selection);

                        if (selection == 0)
                        {
                            m_Level--;
                        }
                        else
                        {
                            m_Level++;
                        }


                    }
                    else if (currentMenuItem.GetMenuItem(selection) is FunctionItem)
                    {
                        ((FunctionItem)currentMenuItem.GetMenuItem(selection)).Select(m_Level, ref currentMenuItem);

                    }
                }

                    selection = (int)((SubMenu)currentMenuItem).Select(m_Level, ref currentMenuItem);
            }

            Console.WriteLine("Bye bye");
            Console.ReadLine();
        }
    }
}
