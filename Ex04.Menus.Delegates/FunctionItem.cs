using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class FunctionItem : MenuItem
    {
        private SelectFunctionDelegate m_SelectFunctionDelegate;

        public FunctionItem(string i_Title) : base(i_Title)
        {
            
        }

        public void AddFunction(SelectFunctionDelegate i_FunctionDelegate)
        {
            m_SelectFunctionDelegate += i_FunctionDelegate;
        }
        public override int? Select(int i_Level, ref SubMenu i_SubMenu)
        {
            m_SelectFunctionDelegate.Invoke();
            return null;
        }


    }
}
