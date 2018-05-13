using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IFunction
    {
        public void Invoke()
        {
            int counterCapital = 0;
            Console.WriteLine("Insert a sentence");
            string sentence = Console.ReadLine();
            foreach(char ch in sentence)
            {
                if(char.IsUpper(ch))
                {
                    counterCapital++;
                }
            }

            Console.WriteLine($"The number of capital letters in the sentence: {counterCapital}");
        }
    }
}
