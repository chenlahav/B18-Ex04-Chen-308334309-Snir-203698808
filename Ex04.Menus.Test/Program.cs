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
            DelegateTest();
        }

        private static void DelegateTest()
        {
            Delegates.MainMenu m_MainMenu = new Delegates.MainMenu();

            Delegates.SubMenu dateTimeMenu = new Delegates.SubMenu("Show Date/Time", m_MainMenu.GetSubMenu());
            Delegates.FunctionItem showTime = new Delegates.FunctionItem("Show Time");
            ShowTime showTimeInstance = new ShowTime();
            showTime.AddFunction(new SelectFunctionDelegate(showTimeInstance.Invoke));
            dateTimeMenu.AddItem(showTime);
            Delegates.FunctionItem showDate = new Delegates.FunctionItem("Show Date");
            ShowDate showDateInstance = new ShowDate();
            showDate.AddFunction(showDateInstance.Invoke);
            dateTimeMenu.AddItem(showDate);

            Delegates.SubMenu versionAndCapitalsMenu = new Delegates.SubMenu("Version and Capitals", m_MainMenu.GetSubMenu());
            Delegates.FunctionItem countCapitals = new Delegates.FunctionItem("Count Capitals");
            CountCapitals countCapitalsInstance = new CountCapitals();
            countCapitals.AddFunction(countCapitalsInstance.Invoke);
            versionAndCapitalsMenu.AddItem(countCapitals);
            Delegates.FunctionItem showVersion = new Delegates.FunctionItem("Show Version");
            ShowVersion showVersionInstance = new ShowVersion();
            showVersion.AddFunction(showVersionInstance.Invoke);
            versionAndCapitalsMenu.AddItem(showVersion);

            m_MainMenu.AddMenuItem(dateTimeMenu);
            m_MainMenu.AddMenuItem(versionAndCapitalsMenu);

            m_MainMenu.Show();
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
