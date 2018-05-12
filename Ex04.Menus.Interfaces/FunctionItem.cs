using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class FunctionItem : MenuItem
    {
        private IFunction m_Function;

        public FunctionItem(string i_Title) : base(i_Title)
        {
            
        }

        public void AddFunction(IFunction i_Function)
        {
            m_Function = i_Function;
        }
        public override int? Select(int i_Level, ref SubMenu i_SubMenu)
        {
            m_Function.Invoke();
            return null;
        }


    }
}
