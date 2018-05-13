using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IFunction
    {
        public void Invoke()
        {
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss"));
        }
    }
}
