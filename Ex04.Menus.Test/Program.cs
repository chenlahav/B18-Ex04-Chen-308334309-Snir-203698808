using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu m_MainMenu = new MainMenu();

            SubMenu dateTimeMenu = new SubMenu("Show Date/Time", m_MainMenu.GetSubMenu());
            FunctionItem showTime = new FunctionItem("Show Time");
            showTime.AddFunction(new ShowTime());
            dateTimeMenu.AddItem(showTime);
            FunctionItem showDate = new FunctionItem("Show Date");
            showDate.AddFunction(new ShowDate());
            dateTimeMenu.AddItem(showDate);

            SubMenu versionAndCapitalsMenu = new SubMenu("Version and Capitals", m_MainMenu.GetSubMenu());
            FunctionItem countCapitals = new FunctionItem("Count Capitals");
            countCapitals.AddFunction(new CountCapitals());
            versionAndCapitalsMenu.AddItem(countCapitals);
            FunctionItem showVersion = new FunctionItem("Show Version");
            showVersion.AddFunction(new ShowVersion());
            versionAndCapitalsMenu.AddItem(showVersion);

            m_MainMenu.AddMenuItem(dateTimeMenu);
            m_MainMenu.AddMenuItem(versionAndCapitalsMenu);

            m_MainMenu.Show();
        }

    }
}
