﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
         public string Title { get; set; }
        public abstract int? Select(int i_Level, ref SubMenu i_SubMenu);

        public MenuItem(string i_Title)
        {
            Title = i_Title;
        }

    }
}
