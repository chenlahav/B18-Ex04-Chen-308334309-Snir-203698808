using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceTest();
        }

        private static void InterfaceTest()
        {
            Interfaces.MainMenu m_MainMenu = new Interfaces.MainMenu();

            Interfaces.SubMenu dateTimeMenu = new Interfaces.SubMenu("Show Date/Time", m_MainMenu.GetSubMenu());
            Interfaces.FunctionItem showTime = new Interfaces.FunctionItem("Show Time");
            showTime.AddFunction(new ShowTime());
            dateTimeMenu.AddItem(showTime);
            Interfaces.FunctionItem showDate = new Interfaces.FunctionItem("Show Date");
            showDate.AddFunction(new ShowDate());
            dateTimeMenu.AddItem(showDate);

            Interfaces.SubMenu versionAndCapitalsMenu = new Interfaces.SubMenu("Version and Capitals", m_MainMenu.GetSubMenu());
            Interfaces.FunctionItem countCapitals = new Interfaces.FunctionItem("Count Capitals");
            countCapitals.AddFunction(new CountCapitals());
            versionAndCapitalsMenu.AddItem(countCapitals);
            Interfaces.FunctionItem showVersion = new Interfaces.FunctionItem("Show Version");
            showVersion.AddFunction(new ShowVersion());
            versionAndCapitalsMenu.AddItem(showVersion);

            m_MainMenu.AddMenuItem(dateTimeMenu);
            m_MainMenu.AddMenuItem(versionAndCapitalsMenu);

            m_MainMenu.Show();
        }
    }
}
