using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowDate : IFunction
    {
        public void Invoke()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
