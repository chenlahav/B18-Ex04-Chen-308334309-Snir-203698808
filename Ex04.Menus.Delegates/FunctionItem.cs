using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{

    public delegate void Invoke();
    public class FunctionItem : MenuItem
    {
        
        private Invoke m_Function;

        public FunctionItem(string i_Title) : base(i_Title)
        {
            
        }

        public void AddFunction(Invoke i_Function)
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
