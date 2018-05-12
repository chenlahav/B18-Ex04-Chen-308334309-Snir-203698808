using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class FunctionItem : MenuItem
    {
        private IFunction m_Function;

        public FunctionItem(string i_Title) : base(i_Title)
        {
            
        }

        public void AddFunction(IFunction i_Function)
        {
            m_Function = i_Function;
        }
        public override void Select(int i_Level)
        {
            m_Function.Invoke();
        }


    }
}
