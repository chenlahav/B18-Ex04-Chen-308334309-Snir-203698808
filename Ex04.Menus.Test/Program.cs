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
            SubMenu garage = new SubMenu("Garage", m_MainMenu.GetSubMenu());
            FunctionItem blowUp = new FunctionItem("Blow Up");
            blowUp.AddFunction(new BlowUpFunc());
            garage.AddItem(blowUp);
            m_MainMenu.AddMenuItem(garage);

            m_MainMenu.Show();
        }

    }

    public class BlowUpFunc : IFunction
    {
        public void Invoke()
        {
            Console.WriteLine("Blow up ending...");
        }
    }
}
